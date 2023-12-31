using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Delete(Blog t)
		{
			_blogDal.Delete(t);
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> GetListAll()
		{
			return _blogDal.GetListAll();
		}

        public List<Blog> GetListWithCategory()
        {
			return _blogDal.GetListWithCategory();
        }

        public void Insert(Blog t)
		{
			_blogDal.Insert(t);
		}

		public void Update(Blog t)
		{
			_blogDal.Update(t);
		}

		public List<Blog> GetListAll(Expression<Func<Blog, bool>> filter)
		{
			return GetListAll();
		}

		public void BlogAdd(Blog blog)
		{
			Insert(blog);
		}

		public void BlogDelete(Blog blog)
		{
			Delete(blog);
		}

		public void BlogUpdate(Blog blog)
		{
			Update(blog);
		}

		public List<Category> GetList()
		{
			throw new NotImplementedException();
		}

		Category IBlogService.GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterID == id);
		}
	}
}
