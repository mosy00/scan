using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace FixPersianLocale
{
    public class Helpers
    {
        static private System.Collections.Generic.SortedDictionary<object, InvokeHelper> m_List = new SortedDictionary<object, InvokeHelper>();
        public static void AddHelper(object Instance, InvokeHelper helper)
        {
            m_List.Add(Instance, helper);
        }
        public static InvokeHelper find(object Instance)
        {
            if (m_List.ContainsKey(Instance))
                return m_List[Instance];
            else
                return null;
        }

    }
    public class InvokeHelper
    {
        static System.Collections.Generic.Dictionary<string, Type> Types = new Dictionary<string, Type>();
        protected object m_Instance;
        Type m_Type;
        public object Instance
        {
            get
            {
                return m_Instance;
            }
        }
        public InvokeHelper(object Instance)
        {
            m_Instance = Instance;
            m_Type = Instance.GetType();
            //            Helpers.AddHelper(Instance, this);
        }
        public InvokeHelper(object Instance, Type type)
        {
            m_Instance = Instance;
            m_Type = type;
        }
        public bool HasField(string FieldName)
        {
            foreach (FieldInfo field in m_Type.GetFields(BindingFlags.NonPublic |BindingFlags.Public |BindingFlags.Instance))
            {
                if (field.Name == FieldName)
                    return true;
            }
            return false;
        }
        public object GetProperty(string FieldName)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty,
                null, this.m_Instance, null);

        }
        public object SetProperty(string FieldName, object Value)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty,
                null, this.m_Instance, new object[] { Value });
        }
        public object GetField(string FieldName, object[] args)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetField,
                null, this.m_Instance, args);
        }
        public object SetField(string FieldName, object[] args)
        {
            return m_Type.InvokeMember(FieldName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField, null, this.m_Instance, args);
        }
        public object SetField(string FieldName, object Value)
        {
            return SetField(FieldName, new object[] { Value });
        }
        public object StaticGetProperty(string PropertyName)
        {
            return m_Type.InvokeMember(PropertyName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty,
                null, null, null);
        }
        public object CreateInstance(object[] args)
        {
            return null;
        }


        public object GetField(string FieldName)
        {
            return GetField(FieldName, null);
        }
        public object InvokeByRef(string MethodName, ref object[] args, ParameterModifier modifiers)
        {
            ParameterModifier[] mod = { modifiers };

            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, m_Instance, args, mod, null, null);
        }
        public object InvokeByOut(string MethodName, object[] args, ParameterModifier modifiers)
        {
            ParameterModifier[] mod = { modifiers };

            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, m_Instance, args, mod, null, null);
        }
        public object Invoke(string MethodName, object[] args)
        {
            return m_Type.InvokeMember(MethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, m_Instance, args);
        }
        public object InvokeStatic(string MethodName, object[] args)
        {
            return m_Type.InvokeMember(MethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, null, args);
        }
        public object InvokeStatic(string MethodName, object arg1, object arg2)
        {
            return InvokeStatic(MethodName, new object[] { arg1, arg2 });
        }
        public object InvokeStatic(string MethodName, object arg1)
        {
            return InvokeStatic(MethodName, new object[] { arg1 });
        }
        public object InvokeStatic(string MethodName)
        {
            return InvokeStatic(MethodName, null);
        }


        public object Invoke(string MethodName)
        {
            return Invoke(MethodName, null);
        }
        public object Invoke(string MethodName, object arg1)
        {
            return Invoke(MethodName, new object[] { arg1 });
        }
        public object Invoke(string MethodName, int arg1)
        {
            return Invoke(MethodName, new object[] { arg1 });
        }
        public object Invoke(string MethodName, object obj1, object obj2)
        {
            return Invoke(MethodName, new object[] { obj1, obj2 });
        }
        public object Invoke(string MethodName, object obj1, object obj2, object obj3)
        {
            return Invoke(MethodName, new object[] { obj1, obj2, obj3 });
        }
        public static Type FindType(string TypeName)
        {
            if (Types.ContainsKey(TypeName))
                return Types[TypeName];
            Type ret = null;
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Module module in assembly.GetModules())
                {
                    foreach (Type type in module.GetTypes())
                    {
                        if (type.FullName == TypeName)
                        {
                            ret = type;
                            Types.Add(TypeName, ret);
                            return ret;
                        }
                    }
                }

            }
            Types.Add(TypeName, ret);

            return ret;


        }



    }
 

}
