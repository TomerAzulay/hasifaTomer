// GENERATED AUTOMATICALLY FROM 'Assets/bloodDrops.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Testinput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Testinput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""bloodDrops"",
    ""maps"": [
        {
            ""name"": ""PD"",
            ""id"": ""e4fe21fb-3703-4ef1-b717-de45fd73f1ae"",
            ""actions"": [
                {
                    ""name"": ""bloodDrops"",
                    ""type"": ""Button"",
                    ""id"": ""a20f9661-a2ce-4486-86f7-28a6e8b2fb67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b38f3a3-ffe8-4e7b-a88b-875a8684b215"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""bloodDrops"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PD
        m_PD = asset.FindActionMap("PD", throwIfNotFound: true);
        m_PD_bloodDrops = m_PD.FindAction("bloodDrops", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PD
    private readonly InputActionMap m_PD;
    private IPDActions m_PDActionsCallbackInterface;
    private readonly InputAction m_PD_bloodDrops;
    public struct PDActions
    {
        private @Testinput m_Wrapper;
        public PDActions(@Testinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @bloodDrops => m_Wrapper.m_PD_bloodDrops;
        public InputActionMap Get() { return m_Wrapper.m_PD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PDActions set) { return set.Get(); }
        public void SetCallbacks(IPDActions instance)
        {
            if (m_Wrapper.m_PDActionsCallbackInterface != null)
            {
                @bloodDrops.started -= m_Wrapper.m_PDActionsCallbackInterface.OnBloodDrops;
                @bloodDrops.performed -= m_Wrapper.m_PDActionsCallbackInterface.OnBloodDrops;
                @bloodDrops.canceled -= m_Wrapper.m_PDActionsCallbackInterface.OnBloodDrops;
            }
            m_Wrapper.m_PDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @bloodDrops.started += instance.OnBloodDrops;
                @bloodDrops.performed += instance.OnBloodDrops;
                @bloodDrops.canceled += instance.OnBloodDrops;
            }
        }
    }
    public PDActions @PD => new PDActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPDActions
    {
        void OnBloodDrops(InputAction.CallbackContext context);
    }
}
