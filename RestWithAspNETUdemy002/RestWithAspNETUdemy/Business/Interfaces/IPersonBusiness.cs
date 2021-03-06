﻿using RestWithAspNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithAspNETUdemy.Business.Interfaces
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
        bool Exists(long? id);
    }
}
