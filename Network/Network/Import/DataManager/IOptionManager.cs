﻿using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.DataManager
{
    public interface IOptionManager
    {
        Option Add(Option option);
        List<Option> GetByCommodityToList(Commodity commodity);
        Option GetById(int OptionNo);
        void Update(int OptionNo, Option option);
        void DeleteById(int OptionNo);
        void DeleteByEntity(Option option);
    }
}
