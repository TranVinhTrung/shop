using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Models;

namespace Shop.Service
{
    public interface IPostCategoryService 
    {
        void Add(PostCategorie postCategorie);
        void Update(PostCategorie postCategorie);
        void Delete(int id);
        IEnumerable<PostCategorie> GetAll();
        IEnumerable<PostCategorie> GetAllByParentID(int parentID);
        PostCategorie GetById(int id);
    }
    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork) 
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = _unitOfWork;
        }
        public void Add(PostCategorie postCategorie)
        {
            _postCategoryRepository.Add(postCategorie);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategorie> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategorie> GetAllByParentID(int parentID)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentID);
        }

        public PostCategorie GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Update(PostCategorie postCategorie)
        {
            _postCategoryRepository.Update(postCategorie);
        }
    }
}
