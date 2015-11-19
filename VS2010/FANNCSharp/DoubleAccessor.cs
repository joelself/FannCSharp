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
 * Title: FANN C# DataAccessor
 */
using FannWrapperDouble;
namespace FANNCSharp.Double
{
    /* Class: DataAccessor
       
       Provides fast access to an array of doubles
    */
    public class DataAccessor : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal DataAccessor(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DataAccessor obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~DataAccessor()
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
                        fanndoublePINVOKE.delete_DoubleAccessor(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /* Method: Get
           Parameters:
                      index - The index of the element to return
   
            Return:
                 A double at index
        */
        public double Get(int index)
        {
            double ret = fanndoublePINVOKE.DoubleAccessor_Get(swigCPtr, index);
            return ret;
        }

        internal static DataAccessor FromPointer(SWIGTYPE_p_double t)
        {
            global::System.IntPtr cPtr = fanndoublePINVOKE.DoubleAccessor_FromPointer(SWIGTYPE_p_double.getCPtr(t));
            DataAccessor ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataAccessor(cPtr, false);
            return ret;
        }
    }
}
