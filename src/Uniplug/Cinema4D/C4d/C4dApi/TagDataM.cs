/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class TagDataM : TagData {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TagDataM(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.TagDataM_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TagDataM obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TagDataM() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_TagDataM(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TagDataM(bool memOwn) : this(C4dApiPINVOKE.new_TagDataM(), memOwn) {
    SwigDirectorConnect();
  }

  private TagDataM() : this(C4dApiPINVOKE.new_TagDataM(), true) {
    SwigDirectorConnect();
  }

  public override bool GetDDescription(GeListNode node, Description description, SWIGTYPE_p_DESCFLAGS_DESC flags) {
    bool ret = (SwigDerivedClassHasMethod("GetDDescription", swigMethodTypes10) ? C4dApiPINVOKE.TagDataM_GetDDescriptionSwigExplicitTagDataM__SWIG_0(swigCPtr, GeListNode.getCPtr(node), Description.getCPtr(description), SWIGTYPE_p_DESCFLAGS_DESC.getCPtr(flags)) : C4dApiPINVOKE.TagDataM_GetDDescription__SWIG_0(swigCPtr, GeListNode.getCPtr(node), Description.getCPtr(description), SWIGTYPE_p_DESCFLAGS_DESC.getCPtr(flags)));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetDDescription(GeListNode node, DDescriptionParams descparams) {
    bool ret = (SwigDerivedClassHasMethod("GetDDescription", swigMethodTypes20) ? C4dApiPINVOKE.TagDataM_GetDDescriptionSwigExplicitTagDataM__SWIG_1(swigCPtr, GeListNode.getCPtr(node), DDescriptionParams.getCPtr(descparams)) : C4dApiPINVOKE.TagDataM_GetDDescription__SWIG_1(swigCPtr, GeListNode.getCPtr(node), DDescriptionParams.getCPtr(descparams)));
    return ret;
  }

  public static BaseContainer GetDataInstance(BaseTag op) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.TagDataM_GetDataInstance__SWIG_0(BaseTag.getCPtr(op));
    BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
    return ret;
  }

  public static BaseContainer GetDataInstance(GeListNode node) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.TagDataM_GetDataInstance__SWIG_1(GeListNode.getCPtr(node));
    BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Init", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateTagDataM_0(SwigDirectorInit);
    if (SwigDerivedClassHasMethod("Free", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateTagDataM_1(SwigDirectorFree);
    if (SwigDerivedClassHasMethod("Read", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateTagDataM_2(SwigDirectorRead);
    if (SwigDerivedClassHasMethod("Write", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateTagDataM_3(SwigDirectorWrite);
    if (SwigDerivedClassHasMethod("CopyTo", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateTagDataM_4(SwigDirectorCopyTo);
    if (SwigDerivedClassHasMethod("Message", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateTagDataM_5(SwigDirectorMessage);
    if (SwigDerivedClassHasMethod("GetBubbleHelp", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateTagDataM_6(SwigDirectorGetBubbleHelp);
    if (SwigDerivedClassHasMethod("GetDocument", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateTagDataM_7(SwigDirectorGetDocument);
    if (SwigDerivedClassHasMethod("GetBranchInfo", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateTagDataM_8(SwigDirectorGetBranchInfo);
    if (SwigDerivedClassHasMethod("IsInstanceOf", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateTagDataM_9(SwigDirectorIsInstanceOf);
    if (SwigDerivedClassHasMethod("GetDDescription", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateTagDataM_10(SwigDirectorGetDDescription__SWIG_0);
    if (SwigDerivedClassHasMethod("GetDParameter", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateTagDataM_11(SwigDirectorGetDParameter);
    if (SwigDerivedClassHasMethod("SetDParameter", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateTagDataM_12(SwigDirectorSetDParameter);
    if (SwigDerivedClassHasMethod("GetDEnabling", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateTagDataM_13(SwigDirectorGetDEnabling);
    if (SwigDerivedClassHasMethod("TranslateDescID", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateTagDataM_14(SwigDirectorTranslateDescID);
    if (SwigDerivedClassHasMethod("IsDocumentRelated", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateTagDataM_15(SwigDirectorIsDocumentRelated);
    if (SwigDerivedClassHasMethod("Draw", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateTagDataM_16(SwigDirectorDraw);
    if (SwigDerivedClassHasMethod("Execute", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateTagDataM_17(SwigDirectorExecute);
    if (SwigDerivedClassHasMethod("AddToExecution", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateTagDataM_18(SwigDirectorAddToExecution);
    if (SwigDerivedClassHasMethod("GetModifiedObjects", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateTagDataM_19(SwigDirectorGetModifiedObjects);
    if (SwigDerivedClassHasMethod("GetDDescription", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateTagDataM_20(SwigDirectorGetDDescription__SWIG_1);
    C4dApiPINVOKE.TagDataM_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(TagDataM));
    return hasDerivedMethod;
  }

  private bool SwigDirectorInit(global::System.IntPtr node) {
    return Init((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false));
  }

  private void SwigDirectorFree(global::System.IntPtr node) {
    Free((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false));
  }

  private bool SwigDirectorRead(global::System.IntPtr node, global::System.IntPtr hf, int level) {
    return Read((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), (hf == global::System.IntPtr.Zero) ? null : new HyperFile(hf, false), level);
  }

  private bool SwigDirectorWrite(global::System.IntPtr node, global::System.IntPtr hf) {
    return Write((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), (hf == global::System.IntPtr.Zero) ? null : new HyperFile(hf, false));
  }

  private bool SwigDirectorCopyTo(global::System.IntPtr dest, global::System.IntPtr snode, global::System.IntPtr dnode, int flags, global::System.IntPtr trn) {
    return CopyTo((dest == global::System.IntPtr.Zero) ? null : new NodeData(dest, false), (snode == global::System.IntPtr.Zero) ? null : new GeListNode(snode, false), (dnode == global::System.IntPtr.Zero) ? null : new GeListNode(dnode, false), (COPYFLAGS)flags, (trn == global::System.IntPtr.Zero) ? null : new AliasTrans(trn, false));
  }

  private bool SwigDirectorMessage(global::System.IntPtr node, int type, global::System.IntPtr data) {
    return Message((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), type, (data == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(data, false));
  }

  private void SwigDirectorGetBubbleHelp(global::System.IntPtr node, global::System.IntPtr str) {
    GetBubbleHelp((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new SWIGTYPE_p_String(str, false));
  }

  private global::System.IntPtr SwigDirectorGetDocument(global::System.IntPtr node) {
    return BaseDocument.getCPtr(GetDocument((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false))).Handle;
  }

  private int SwigDirectorGetBranchInfo(global::System.IntPtr node, global::System.IntPtr info, int max, int flags) {
    return GetBranchInfo((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), (info == global::System.IntPtr.Zero) ? null : new BranchInfo(info, false), max, (GETBRANCHINFO)flags);
  }

  private bool SwigDirectorIsInstanceOf(global::System.IntPtr node, int type) {
    return IsInstanceOf((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), type);
  }

  private bool SwigDirectorGetDDescription__SWIG_0(global::System.IntPtr node, global::System.IntPtr description, global::System.IntPtr flags) {
    return GetDDescription((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), (description == global::System.IntPtr.Zero) ? null : new Description(description, false), new SWIGTYPE_p_DESCFLAGS_DESC(flags, false));
  }

  private bool SwigDirectorGetDParameter(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, global::System.IntPtr flags) {
    return GetDParameter((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new DescID(id, false), new GeData(t_data, false), new SWIGTYPE_p_DESCFLAGS_GET(flags, false));
  }

  private bool SwigDirectorSetDParameter(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, global::System.IntPtr flags) {
    return SetDParameter((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new DescID(id, false), new GeData(t_data, false), new SWIGTYPE_p_DESCFLAGS_SET(flags, false));
  }

  private bool SwigDirectorGetDEnabling(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, int flags, global::System.IntPtr itemdesc) {
    return GetDEnabling((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new DescID(id, false), new GeData(t_data, false), (DESCFLAGS_ENABLE)flags, (itemdesc == global::System.IntPtr.Zero) ? null : new BaseContainer(itemdesc, false));
  }

  private bool SwigDirectorTranslateDescID(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr res_id, global::System.IntPtr res_at) {
    return TranslateDescID((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new DescID(id, false), new DescID(res_id, false), new SWIGTYPE_p_p_C4DAtom(res_at, false));
  }

  private bool SwigDirectorIsDocumentRelated(global::System.IntPtr node, global::System.IntPtr docrelated) {
    return IsDocumentRelated((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), new SWIGTYPE_p_Bool(docrelated, false));
  }

  private bool SwigDirectorDraw(global::System.IntPtr tag, global::System.IntPtr op, global::System.IntPtr bd, global::System.IntPtr bh) {
    return Draw((tag == global::System.IntPtr.Zero) ? null : new BaseTag(tag, false), (op == global::System.IntPtr.Zero) ? null : new BaseObject(op, false), (bd == global::System.IntPtr.Zero) ? null : new BaseDraw(bd, false), (bh == global::System.IntPtr.Zero) ? null : new BaseDrawHelp(bh, false));
  }

  private int SwigDirectorExecute(global::System.IntPtr tag, global::System.IntPtr doc, global::System.IntPtr op, global::System.IntPtr bt, int priority, int flags) {
    return (int)Execute((tag == global::System.IntPtr.Zero) ? null : new BaseTag(tag, false), (doc == global::System.IntPtr.Zero) ? null : new BaseDocument(doc, false), (op == global::System.IntPtr.Zero) ? null : new BaseObject(op, false), (bt == global::System.IntPtr.Zero) ? null : new BaseThread(bt, false), priority, (EXECUTIONFLAGS)flags);
  }

  private bool SwigDirectorAddToExecution(global::System.IntPtr tag, global::System.IntPtr list) {
    return AddToExecution((tag == global::System.IntPtr.Zero) ? null : new BaseTag(tag, false), (list == global::System.IntPtr.Zero) ? null : new PriorityList(list, false));
  }

  private bool SwigDirectorGetModifiedObjects(global::System.IntPtr tag, global::System.IntPtr doc, global::System.IntPtr op, global::System.IntPtr pluginownedop, global::System.IntPtr /* constMatrix&_imtype_out */ op_mg, double lod, int flags, global::System.IntPtr thread) {
    Fusee.Math.double4x4 mtx_op_mg;
    unsafe {mtx_op_mg = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4((double *)op_mg);}
    /* constMatrix&_csdirectorin_pre */
    try {
      return GetModifiedObjects((tag == global::System.IntPtr.Zero) ? null : new BaseTag(tag, false), (doc == global::System.IntPtr.Zero) ? null : new BaseDocument(doc, false), new SWIGTYPE_p_p_BaseObject(op, false), new SWIGTYPE_p_Bool(pluginownedop, false), ref mtx_op_mg /* constMatrix&_csdirectorin */, lod, flags, (thread == global::System.IntPtr.Zero) ? null : new BaseThread(thread, false));
    } finally {
        unsafe {Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(mtx_op_mg, (double *)op_mg);}
        /* constMatrix&_csdirectorin_post */
    }
  }

  private bool SwigDirectorGetDDescription__SWIG_1(global::System.IntPtr node, global::System.IntPtr descparams) {
    return GetDDescription((node == global::System.IntPtr.Zero) ? null : new GeListNode(node, false), (descparams == global::System.IntPtr.Zero) ? null : new DDescriptionParams(descparams, false));
  }

  public delegate bool SwigDelegateTagDataM_0(global::System.IntPtr node);
  public delegate void SwigDelegateTagDataM_1(global::System.IntPtr node);
  public delegate bool SwigDelegateTagDataM_2(global::System.IntPtr node, global::System.IntPtr hf, int level);
  public delegate bool SwigDelegateTagDataM_3(global::System.IntPtr node, global::System.IntPtr hf);
  public delegate bool SwigDelegateTagDataM_4(global::System.IntPtr dest, global::System.IntPtr snode, global::System.IntPtr dnode, int flags, global::System.IntPtr trn);
  public delegate bool SwigDelegateTagDataM_5(global::System.IntPtr node, int type, global::System.IntPtr data);
  public delegate void SwigDelegateTagDataM_6(global::System.IntPtr node, global::System.IntPtr str);
  public delegate global::System.IntPtr SwigDelegateTagDataM_7(global::System.IntPtr node);
  public delegate int SwigDelegateTagDataM_8(global::System.IntPtr node, global::System.IntPtr info, int max, int flags);
  public delegate bool SwigDelegateTagDataM_9(global::System.IntPtr node, int type);
  public delegate bool SwigDelegateTagDataM_10(global::System.IntPtr node, global::System.IntPtr description, global::System.IntPtr flags);
  public delegate bool SwigDelegateTagDataM_11(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, global::System.IntPtr flags);
  public delegate bool SwigDelegateTagDataM_12(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, global::System.IntPtr flags);
  public delegate bool SwigDelegateTagDataM_13(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr t_data, int flags, global::System.IntPtr itemdesc);
  public delegate bool SwigDelegateTagDataM_14(global::System.IntPtr node, global::System.IntPtr id, global::System.IntPtr res_id, global::System.IntPtr res_at);
  public delegate bool SwigDelegateTagDataM_15(global::System.IntPtr node, global::System.IntPtr docrelated);
  public delegate bool SwigDelegateTagDataM_16(global::System.IntPtr tag, global::System.IntPtr op, global::System.IntPtr bd, global::System.IntPtr bh);
  public delegate int SwigDelegateTagDataM_17(global::System.IntPtr tag, global::System.IntPtr doc, global::System.IntPtr op, global::System.IntPtr bt, int priority, int flags);
  public delegate bool SwigDelegateTagDataM_18(global::System.IntPtr tag, global::System.IntPtr list);
  public delegate bool SwigDelegateTagDataM_19(global::System.IntPtr tag, global::System.IntPtr doc, global::System.IntPtr op, global::System.IntPtr pluginownedop, global::System.IntPtr /* constMatrix&_imtype_out */ op_mg, double lod, int flags, global::System.IntPtr thread);
  public delegate bool SwigDelegateTagDataM_20(global::System.IntPtr node, global::System.IntPtr descparams);

  private SwigDelegateTagDataM_0 swigDelegate0;
  private SwigDelegateTagDataM_1 swigDelegate1;
  private SwigDelegateTagDataM_2 swigDelegate2;
  private SwigDelegateTagDataM_3 swigDelegate3;
  private SwigDelegateTagDataM_4 swigDelegate4;
  private SwigDelegateTagDataM_5 swigDelegate5;
  private SwigDelegateTagDataM_6 swigDelegate6;
  private SwigDelegateTagDataM_7 swigDelegate7;
  private SwigDelegateTagDataM_8 swigDelegate8;
  private SwigDelegateTagDataM_9 swigDelegate9;
  private SwigDelegateTagDataM_10 swigDelegate10;
  private SwigDelegateTagDataM_11 swigDelegate11;
  private SwigDelegateTagDataM_12 swigDelegate12;
  private SwigDelegateTagDataM_13 swigDelegate13;
  private SwigDelegateTagDataM_14 swigDelegate14;
  private SwigDelegateTagDataM_15 swigDelegate15;
  private SwigDelegateTagDataM_16 swigDelegate16;
  private SwigDelegateTagDataM_17 swigDelegate17;
  private SwigDelegateTagDataM_18 swigDelegate18;
  private SwigDelegateTagDataM_19 swigDelegate19;
  private SwigDelegateTagDataM_20 swigDelegate20;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(GeListNode) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(GeListNode) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(GeListNode), typeof(HyperFile), typeof(int) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(GeListNode), typeof(HyperFile) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(NodeData), typeof(GeListNode), typeof(GeListNode), typeof(COPYFLAGS), typeof(AliasTrans) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(GeListNode), typeof(int), typeof(SWIGTYPE_p_void) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(GeListNode), typeof(SWIGTYPE_p_String) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(GeListNode) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(GeListNode), typeof(BranchInfo), typeof(int), typeof(GETBRANCHINFO) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(GeListNode), typeof(int) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(GeListNode), typeof(Description), typeof(SWIGTYPE_p_DESCFLAGS_DESC) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(GeListNode), typeof(DescID), typeof(GeData), typeof(SWIGTYPE_p_DESCFLAGS_GET) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(GeListNode), typeof(DescID), typeof(GeData), typeof(SWIGTYPE_p_DESCFLAGS_SET) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(GeListNode), typeof(DescID), typeof(GeData), typeof(DESCFLAGS_ENABLE), typeof(BaseContainer) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] { typeof(GeListNode), typeof(DescID), typeof(DescID), typeof(SWIGTYPE_p_p_C4DAtom) };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(GeListNode), typeof(SWIGTYPE_p_Bool) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(BaseTag), typeof(BaseObject), typeof(BaseDraw), typeof(BaseDrawHelp) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(BaseTag), typeof(BaseDocument), typeof(BaseObject), typeof(BaseThread), typeof(int), typeof(EXECUTIONFLAGS) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(BaseTag), typeof(PriorityList) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(BaseTag), typeof(BaseDocument), typeof(SWIGTYPE_p_p_BaseObject), typeof(SWIGTYPE_p_Bool), typeof(Fusee.Math.double4x4 /* constMatrix&_cstype */).MakeByRefType(), typeof(double), typeof(int), typeof(BaseThread) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(GeListNode), typeof(DDescriptionParams) };
}

}
