// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""c5e2e51f-756e-484b-8854-86c015728203"",
            ""actions"": [
                {
                    ""name"": ""PaddleLeft"",
                    ""type"": ""Button"",
                    ""id"": ""7e144f8a-388f-4a87-a97b-48f0491b306e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PaddleRight"",
                    ""type"": ""Button"",
                    ""id"": ""034645cd-a8ae-497a-bb92-b77da312b722"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57f66380-1ec4-453c-a983-ca2993fe8e5e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PaddleLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2615ed9-20b1-48d3-9bf2-3ac70158019b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PaddleRight"",
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
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_PaddleLeft = m_PlayerActions.FindAction("PaddleLeft", throwIfNotFound: true);
        m_PlayerActions_PaddleRight = m_PlayerActions.FindAction("PaddleRight", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_PaddleLeft;
    private readonly InputAction m_PlayerActions_PaddleRight;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PaddleLeft => m_Wrapper.m_PlayerActions_PaddleLeft;
        public InputAction @PaddleRight => m_Wrapper.m_PlayerActions_PaddleRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @PaddleLeft.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleLeft;
                @PaddleLeft.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleLeft;
                @PaddleLeft.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleLeft;
                @PaddleRight.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleRight;
                @PaddleRight.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleRight;
                @PaddleRight.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPaddleRight;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PaddleLeft.started += instance.OnPaddleLeft;
                @PaddleLeft.performed += instance.OnPaddleLeft;
                @PaddleLeft.canceled += instance.OnPaddleLeft;
                @PaddleRight.started += instance.OnPaddleRight;
                @PaddleRight.performed += instance.OnPaddleRight;
                @PaddleRight.canceled += instance.OnPaddleRight;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerActionsActions
    {
        void OnPaddleLeft(InputAction.CallbackContext context);
        void OnPaddleRight(InputAction.CallbackContext context);
    }
}
