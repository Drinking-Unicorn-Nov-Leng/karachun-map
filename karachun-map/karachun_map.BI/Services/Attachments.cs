using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.BI.Interfaces;
using karachun_map.Data.Base;
using AutoMapper;
using karachun_map.BI.Options;

namespace karachun_map.BI.Services
{
    public class Attachments : IAttachments
    {
            private readonly AttachmentConfig _config;
            private readonly IMapper _mapper;
            private readonly IDataSend _dataSend;

            public Attachments(IMapper mapper, AttachmentConfig config, IDataSend dataSend)
            {
                _mapper = mapper;
                _config = config;
                _dataSend = dataSend;
            }

        public async Task<string> Upload(Attachment attachment)
        {
            return await _dataSend.PostFileWithStringContent(
                (attachment.Stream, attachment.Name),
                _config.Url,
                _config.Token
                );
        }
    }
}
