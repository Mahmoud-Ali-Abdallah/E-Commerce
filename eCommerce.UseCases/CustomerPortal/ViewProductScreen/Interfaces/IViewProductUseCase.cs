﻿using eCommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.ViewProductScreen
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}
