using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Services
{
    public class MatchingTemplateService:IMatchingTemplateService
    {
        private readonly IRepository<MatchingTemplate> _templateRepository;

        public MatchingTemplateService(IRepository<MatchingTemplate> templateRepository)
        {
            _templateRepository = templateRepository;
        }

        public void CreateTemplate(Entities.MatchingTemplate template)
        {
            _templateRepository.Add(template);
        }

        public void UpdateTemplate(Entities.MatchingTemplate template)
        {
            _templateRepository.Update(template);
        }

        public void DeleteTemplate(int templateId)
        {
            var template = _templateRepository.GetById(templateId);
            _templateRepository.Delete(template);
        }

        public IEnumerable<Entities.MatchingTemplate> ListAllTemplate()
        {
            return _templateRepository.GetAll().AsEnumerable();
        }
    }
}
