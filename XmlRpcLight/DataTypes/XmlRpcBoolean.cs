﻿namespace XmlRpcLight.DataTypes {
    public class XmlRpcBoolean {
        private readonly bool _value;
        public XmlRpcBoolean() {}
        public XmlRpcBoolean(bool val) {
            _value = val;
        }
        public override string ToString() {
            return _value.ToString();
        }
        public override int GetHashCode() {
            return _value.GetHashCode();
        }
        public override bool Equals(object o) {
            if (o == null || !(o is XmlRpcBoolean))
                return false;
            var dbl = o as XmlRpcBoolean;
            return (dbl._value == _value);
        }
        public static bool operator ==(
            XmlRpcBoolean xi,
            XmlRpcBoolean xj) {
            if (((object) xi) == null && ((object) xj) == null)
                return true;
            if (((object) xi) == null || ((object) xj) == null)
                return false;
            return xi._value == xj._value;
        }

        public static bool operator !=(
            XmlRpcBoolean xi,
            XmlRpcBoolean xj) {
            return !(xi == xj);
        }

        public static implicit operator bool(XmlRpcBoolean x) {
            return x._value;
        }

        public static implicit operator XmlRpcBoolean(bool x) {
            return new XmlRpcBoolean(x);
        }
    }
}