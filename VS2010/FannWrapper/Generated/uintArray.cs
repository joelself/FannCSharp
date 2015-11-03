//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FannWrap {

public class uintArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal uintArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(uintArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~uintArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannPINVOKE.delete_uintArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uintArray(int nelements) : this(SwigFannPINVOKE.new_uintArray(nelements), true) {
  }

  public uint getitem(int index) {
    uint ret = SwigFannPINVOKE.uintArray_getitem(swigCPtr, index);
    return ret;
  }

  public void setitem(int index, uint value) {
    SwigFannPINVOKE.uintArray_setitem(swigCPtr, index, value);
  }

  public SWIGTYPE_p_unsigned_int cast() {
    global::System.IntPtr cPtr = SwigFannPINVOKE.uintArray_cast(swigCPtr);
    SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
    return ret;
  }

  public static uintArray frompointer(SWIGTYPE_p_unsigned_int t) {
    global::System.IntPtr cPtr = SwigFannPINVOKE.uintArray_frompointer(SWIGTYPE_p_unsigned_int.getCPtr(t));
    uintArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new uintArray(cPtr, false);
    return ret;
  }

}

}