using System;

namespace GraphQL.DataLayer
{
    public abstract class BaseDTO : IDTO
    {
        private Guid _id = Guid.NewGuid();
        public override bool Equals(object obj)
        {
            if (obj is BaseDTO)
            {
                var ord = obj as BaseDTO;
                return ord._id == this._id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
