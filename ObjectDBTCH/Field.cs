using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace field_space
{
    public class Field
    {
        private object fld_backgrd;
        /// <remarks>field foregroud</remarks>
        private object fld_foregrnd;
        private int value;
        private object state;

        public Field(object back, object fore)
        {
            fld_foregrnd = fore;
            fld_backgrd = back;
        }
        public Field()
        {
            // empty constructor
        }
        public object Fld_foregrnd
        {
            get
            {
                return fld_foregrnd;
            }

            set
            {
                fld_foregrnd = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public object Fld_backgrd
        {
            get
            {
                return fld_backgrd;
            }

            set
            {
                fld_backgrd = value;
            }
        }

        public object State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}