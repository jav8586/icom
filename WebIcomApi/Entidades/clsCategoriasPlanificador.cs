﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIcomApi.Entidades
{
    public class clsCategoriasPlanificador
    {
        public String idcategoria { get; set; }
        public String nombre { get; set; }
        public String comentario { get; set; }
        public String fechahora { get; set; }        
        public int idusuario { get; set; }

    }
}