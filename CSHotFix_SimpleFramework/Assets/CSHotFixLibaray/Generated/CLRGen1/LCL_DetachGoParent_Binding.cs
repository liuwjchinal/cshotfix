
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class LCL_DetachGoParent_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(LCL.DetachGoParent);

            field = type.GetField("m_DetachGoChild", flag);
            app.RegisterCLRFieldGetter(field, get_m_DetachGoChild_0);
            app.RegisterCLRFieldSetter(field, set_m_DetachGoChild_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new LCL.DetachGoParent());
            app.RegisterCLRCreateArrayInstance(type, s => new LCL.DetachGoParent[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_m_DetachGoChild_0(ref object o)
        {
            return ((LCL.DetachGoParent)o).m_DetachGoChild;
        }
        static void set_m_DetachGoChild_0(ref object o, object v)
        {
LCL.DetachGoParent _o = (LCL.DetachGoParent)o;
    _o.m_DetachGoChild = (LCL.DetachGoChild)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new LCL.DetachGoParent();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
