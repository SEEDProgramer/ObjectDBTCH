using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace field_space
{
    public class Field
    {
        private object _fld_backgrd;
        /// <remarks>field foregroud what is bacground of the field</remarks>
        private object _fld_foregrnd;
        private int _value;
        private object _state;
        private bool _check;

        public Field(int _value,object back, object fore)
        {
            _fld_foregrnd = fore;
            _fld_backgrd = back;
            _check = false;
            this._value = _value;
        }
        public Field(int _value)
        {
            this._value = _value;
            Check = false;
            // empty constructor
        }
        public object Fld_foregrnd
        {
            get
            {
                return _fld_foregrnd;
            }

            set
            {
                _fld_foregrnd = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
        /// <summary>
        /// field background what is bacground of the field
        /// </summary>
        public object Fld_backgrd
        {
            get
            {
                return _fld_backgrd;
            }

            set
            {
                _fld_backgrd = value;
            }
        }

        public object State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public bool Check
        {
            get
            {
                return _check;
            }

            set
            {
                _check = value;
            }
        }

        public void Chng_check()
        {
            Check = !Check;
        }
    }
}