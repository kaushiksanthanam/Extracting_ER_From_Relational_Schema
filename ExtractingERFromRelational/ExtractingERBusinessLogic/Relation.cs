﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic
{
    public class Relation
    {
        #region Variables

        public string relationName;
        public List<string> primaryKeys;
        public Dictionary<string, AttributeType> attributeDict;

        #endregion

        #region Constructor

        public Relation()
        {
            relationName = string.Empty;
            primaryKeys = new List<string>();
            attributeDict = new Dictionary<string, AttributeType>();
        
        }

        #endregion

        #region Public Methods

        #endregion

    }
}
