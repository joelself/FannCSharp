//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------
/*
 * Title: FANN C# ArrayAccessor
 */
using FannWrapperFixed;
namespace FANNCSharp.Fixed
{
    /* Class: ArrayAccessor
       
       Provides fast access to an array of array of ints
    */
    public class ArrayAccessor : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ArrayAccessor(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ArrayAccessor obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~ArrayAccessor()
        {
            Dispose();
        }
        /* Method: Dispose
        
            Destructs the accessor. Must be called manually.
        */
        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        fannfixedPINVOKE.delete_IntArrayAccessor(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /* Method: Get
           Parameters:
                      index - The index of the array to return
   
            Return:
                 A <IntAccessor> that provides fast access to an array
                 of ints
        */
        public ArrayAccessor Get(int index)
        {
            global::System.IntPtr cPtr = fannfixedPINVOKE.IntArrayAccessor_Get__SWIG_0(swigCPtr, index);
            ArrayAccessor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArrayAccessor(cPtr, false);
            return ret;
        }
        /* Method: Get
           Parameters:
                      x - The index of the array to access
                      y - The index in array x to return
   
            Return:
                 A int at position x,y in the array
        */
        public int Get(int x, int y)
        {
            int ret = fannfixedPINVOKE.IntArrayAccessor_Get__SWIG_1(swigCPtr, x, y);
            return ret;
        }

        internal static ArrayAccessor FromPointer(SWIGTYPE_p_p_int t)
        {
            global::System.IntPtr cPtr = fannfixedPINVOKE.IntArrayAccessor_FromPointer(SWIGTYPE_p_p_int.getCPtr(t));
            ArrayAccessor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArrayAccessor(cPtr, false);
            return ret;
        }
    }
}