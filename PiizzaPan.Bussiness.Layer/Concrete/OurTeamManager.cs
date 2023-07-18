using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;
using PiizzaPan.DataAccessLayer.Abstract;
using PiizzaPan.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.Bussiness.Layer.Concrete
{
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;
        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TDelete(OurTeam t)
        {
            _ourTeamDal.Delete(t);
        }

        public OurTeam TGetById(int id)
        {
            return _ourTeamDal.GetById(id);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }

        public void TInsert(OurTeam t)
        {
            _ourTeamDal.Insert(t);
        }

        public void TUpdate(OurTeam t)
        {
            _ourTeamDal.Update(t);
        }
    }
}
