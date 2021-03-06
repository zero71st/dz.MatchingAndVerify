﻿using dz.MatchingAndVerify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Interfaces.Services
{
    public interface IMatchingTemplateService
    {
        void CreateTemplate(MatchingTemplate template);
        void UpdateTemplate(MatchingTemplate template);
        void DeleteTemplate(int templateId);
        IEnumerable<MatchingTemplate> ListAllTemplate();
    }
}
