// GENERATED AUTOMATICALLY FROM 'Assets/02.Scripts/PlayerControllerAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControllerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControllerAction"",
    ""maps"": [
        {
            ""name"": ""Simple"",
            ""id"": ""1d12d302-07c6-4619-8405-665d06ca8f9d"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f266a804-be89-4a96-b8e8-c14d335d02cd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""43352d76-8ffa-4a15-ae74-5d5713b97868"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""14998eec-f7ed-4f22-8828-eee9a9d8c02b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4a3eb3b8-4617-4dcf-93fe-f25742a13894"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""85f2d646-94dc-4d8f-aca8-72b24fc41adc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4ba035b4-ba94-4f54-a6ca-7c55dfe60e27"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3efad157-841a-4f74-92f9-1a1c5ccf368c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""050a5c8f-287f-4d5e-a10c-fc6d1bc99fb2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""0089c10e-db47-4fe8-ac46-85c8ea8cb55d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8d21b977-3a8f-4463-bf39-f0b9f158358e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3639ab19-a71d-41c2-a6d9-9170ec4fd73f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa1d21e4-0116-4d19-ad28-551fdf6e85b1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""df8695a2-f2f4-4626-ab79-fbb0709e3419"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Simple
        m_Simple = asset.FindActionMap("Simple", throwIfNotFound: true);
        m_Simple_Look = m_Simple.FindAction("Look", throwIfNotFound: true);
        m_Simple_Move = m_Simple.FindAction("Move", throwIfNotFound: true);
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

    // Simple
    private readonly InputActionMap m_Simple;
    private ISimpleActions m_SimpleActionsCallbackInterface;
    private readonly InputAction m_Simple_Look;
    private readonly InputAction m_Simple_Move;
    public struct SimpleActions
    {
        private @PlayerControllerAction m_Wrapper;
        public SimpleActions(@PlayerControllerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Simple_Look;
        public InputAction @Move => m_Wrapper.m_Simple_Move;
        public InputActionMap Get() { return m_Wrapper.m_Simple; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SimpleActions set) { return set.Get(); }
        public void SetCallbacks(ISimpleActions instance)
        {
            if (m_Wrapper.m_SimpleActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_SimpleActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_SimpleActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_SimpleActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_SimpleActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SimpleActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SimpleActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_SimpleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public SimpleActions @Simple => new SimpleActions(this);
    public interface ISimpleActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
