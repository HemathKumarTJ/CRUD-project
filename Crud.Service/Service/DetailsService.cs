using Crud.Core.IRepositories;
using Crud.Core.IService;
using Crud.Core.Model;
using Crud.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Service.Service
{

    public class DetailsServices : IDetailsServices
    {
        private readonly IDetailsRepository _detailsRepository;

        public DetailsServices(IDetailsRepository detailsRepository)
        {
            _detailsRepository = detailsRepository;
        }
        #region Create
        public void CreateDetails(Details details)
        {
            //business condition
            if (details.FirstName != string.Empty && details.Course != string.Empty)
            {
                _detailsRepository.CreateDetails(details);
            }
        }
        #endregion

        #region  Read
        public List<Details> ListMethod()
        {

            return _detailsRepository.ListMethod();
        }
        #endregion

        public Details SaveMethod(int id)
        {
            return _detailsRepository.SaveMethod(id);
        }
        public void Update(int id, Details details)
        {
            _detailsRepository.Update(id, details);
        }


        public void DeleteDone(int id)
        {
            _detailsRepository.DeleteDone(id);
        }
    }
}
