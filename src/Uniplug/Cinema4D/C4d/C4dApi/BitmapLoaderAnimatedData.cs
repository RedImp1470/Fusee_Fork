/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class BitmapLoaderAnimatedData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BitmapLoaderAnimatedData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BitmapLoaderAnimatedData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BitmapLoaderAnimatedData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_BitmapLoaderAnimatedData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BitmapLoaderAnimatedData() : this(C4dApiPINVOKE.new_BitmapLoaderAnimatedData(), true) {
  }

  public Filename moviename {
    set {
      C4dApiPINVOKE.BitmapLoaderAnimatedData_moviename_set(swigCPtr, Filename.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BitmapLoaderAnimatedData_moviename_get(swigCPtr);
      Filename ret = (cPtr == global::System.IntPtr.Zero) ? null : new Filename(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_void moviedata {
    set {
      C4dApiPINVOKE.BitmapLoaderAnimatedData_moviedata_set(swigCPtr, SWIGTYPE_p_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BitmapLoaderAnimatedData_moviedata_get(swigCPtr);
      SWIGTYPE_p_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_void(cPtr, false);
      return ret;
    } 
  }

}

}
