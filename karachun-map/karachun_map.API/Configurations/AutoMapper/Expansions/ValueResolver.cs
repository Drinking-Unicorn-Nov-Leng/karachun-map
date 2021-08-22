using AutoMapper;
using karachun_map.BI.Options;
using karachun_map.Data.Entity;
using karachun_map.General.Expansions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using karachun_map.BI.Interfaces;
using karachun_map.Data.Base;
using karachun_map.Data.Dto;
using karachun_map.Data.Entity;

namespace karachun_map.API.Configurations.AutoMapper
{
    public class FormatterObjectToString : IValueResolver<object, object, string>
    {
        private readonly IMapper _mapper;

        public FormatterObjectToString(IMapper mapper)
        {
            _mapper = mapper;
        }

        public string Resolve(object source, object destination, string result, ResolutionContext context)
        {
            return result;
        }
    }

    public class FormatterFileToAttachment : IValueResolver<Data.Base.Attachment, Data.Entity.Attachment, string>
    {
        private readonly IAttachments _attachments;
        private readonly IMapper _mapper;

        public FormatterFileToAttachment(IAttachments attachments, IMapper mapper)
        {
            _attachments = attachments;
            _mapper = mapper;
        }

        public string Resolve(Data.Base.Attachment source, Data.Entity.Attachment destination, string result, ResolutionContext context)
        {
            return DownloadFile(source).GetAwaiter().GetResult();
        }

        private async Task<string> DownloadFile(Data.Base.Attachment source) =>
            await _attachments.Upload(source);
    }

    public class FormatterPlaceIdToPlace : IValueResolver<TourInputDto, Tour, IList<Place>>
    {
        private readonly IPlaces _places;
        private readonly IMapper _mapper;

        public FormatterPlaceIdToPlace(IPlaces places, IMapper mapper)
        {
            _places = places;
            _mapper = mapper;
        }

        public IList<Place> Resolve(TourInputDto source, Tour destination, IList<Place> result, ResolutionContext context)
        {
            return GetPlaces(source.PlacesIds).GetAwaiter().GetResult();
        }

        private async Task<IList<Place>> GetPlaces(int[] ids) =>
            await _places.Get(ids);
    }
}

//FormatterPlaceIdToPlace