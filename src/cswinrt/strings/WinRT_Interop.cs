// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.


using System;
using System.Runtime.InteropServices;

#pragma warning disable CS0649

namespace WinRT.Interop
{
    // IActivationFactory
    [Guid("00000035-0000-0000-C000-000000000046")]
    internal unsafe struct IActivationFactoryVftbl
    {
        public IInspectable.Vftbl IInspectableVftbl;
        private void* _ActivateInstance;
        public delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int> ActivateInstance => (delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)_ActivateInstance;

        internal static readonly Guid IID = new(0x00000035, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46);
    }

    // IDelegate
    internal struct IDelegateVftbl
    {
        public IUnknownVftbl IUnknownVftbl;
        public IntPtr Invoke;
    }

    [Guid("64BD43F8-bFEE-4EC4-B7EB-2935158DAE21")]
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct IReferenceTrackerTargetVftbl
    {
        public global::WinRT.Interop.IUnknownVftbl IUnknownVftbl;
        private void* _AddRefFromReferenceTracker;
        public delegate* unmanaged[Stdcall]<IntPtr, uint> AddRefFromReferenceTracker => (delegate* unmanaged[Stdcall]<IntPtr, uint>)_AddRefFromReferenceTracker;
        private void* _ReleaseFromReferenceTracker;
        public delegate* unmanaged[Stdcall]<IntPtr, uint> ReleaseFromReferenceTracker => (delegate* unmanaged[Stdcall]<IntPtr, uint>)_ReleaseFromReferenceTracker;
        private void* _Peg;
        private void* _Unpeg;

        internal static readonly Guid IID = new(0x64BD43F8, 0xbFEE, 0x4EC4, 0xB7, 0xEB, 0x29, 0x35, 0x15, 0x8D, 0xAE, 0x21);
    }

}
