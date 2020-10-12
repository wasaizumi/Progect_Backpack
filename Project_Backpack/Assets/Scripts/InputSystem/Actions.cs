// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerAction"",
            ""id"": ""41a14278-f37f-4ca2-bf33-1b8733ac7e80"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e1d85f39-7055-47ad-9ed2-d1b388aa7579"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reaction_A"",
                    ""type"": ""Button"",
                    ""id"": ""fb6932ba-0876-4c18-be59-603036664980"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reaction_B"",
                    ""type"": ""Button"",
                    ""id"": ""2d20ca65-da9c-4c1e-84ad-0261d057d38b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f910cbde-e932-48dd-8641-b3ffd9f90f28"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5363904-49de-4b72-9cf4-5123b293dcf5"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector [WASD]"",
                    ""id"": ""cfc0297d-4168-4066-bc50-40cd7897f5f2"",
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
                    ""id"": ""09a0dee9-0144-440a-a37e-af1bc69daf0f"",
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
                    ""id"": ""71335948-b56e-40d6-9eae-3f2a8a771c5c"",
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
                    ""id"": ""1d52b13b-7d2c-43d9-b709-7673ec81493b"",
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
                    ""id"": ""dfa88577-56df-4be2-8539-4ac837b17767"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector [NumPad]"",
                    ""id"": ""a92c5f98-d625-471a-9965-2df609070aca"",
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
                    ""id"": ""6d23aef4-dd93-498c-a807-9aba3fd607e7"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9458d629-1d56-48b8-877e-e93e543b8e20"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8e06cac4-e691-4466-9e69-d2bc20e27a01"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6e0cea4-f928-4028-8428-b81d496ea785"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector [Arrow]"",
                    ""id"": ""d46e841d-54b0-4c6e-aa2b-b90ade56c0f2"",
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
                    ""id"": ""f31d5641-bfba-454b-b9be-2740817e994c"",
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
                    ""id"": ""4d88caf3-2590-4b8c-8cfe-510d1f8ab4f4"",
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
                    ""id"": ""fcb7c369-590e-44dd-8880-d044470f2101"",
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
                    ""id"": ""8f86ef12-352b-45bf-adcc-74519c515895"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bfae1f3d-2df2-4daa-b6b3-44930ea3fa4b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bf4db94-69be-4699-af79-40d9cb27986d"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01315b87-0830-420e-99de-8b546cc62fca"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b9d75f7-0750-4cbb-908c-323fe882aa39"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfd52ef0-4400-44be-9a67-e117ab292ec2"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ec4a27c-b778-4a0a-befa-3e2001aa2826"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reaction_B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraAction"",
            ""id"": ""ce1c0296-f161-4575-9845-09f231e3683d"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a154a444-d36b-452c-b558-5fd8977b98b6"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Updown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""807edbbe-7884-4271-a14b-abc8d3d57a29"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""4efe955b-fddf-49b9-98fd-a24f586a346e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b52e18e-ac14-49b7-afa6-b4eb303a9cf9"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8273a95d-145b-4771-a885-c72ea304ebc9"",
                    ""path"": ""<DualShockGamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83f6bcea-a2aa-4ef3-a48b-c04535206402"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e55cba-b1d9-484e-9384-ee8090e69617"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f9ac626-3c00-43bb-aa7d-808d68e27ce5"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Updown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cafa3e1-e16f-4e20-a139-e495bb6870e5"",
                    ""path"": ""<DualShockGamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Updown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SystemAction"",
            ""id"": ""281349ad-f05f-4118-a4d5-659ada6a12c1"",
            ""actions"": [
                {
                    ""name"": ""EndGame"",
                    ""type"": ""Button"",
                    ""id"": ""8a4b3dd9-701f-4973-b4c2-471e02913b82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""01e67400-7399-4ec8-8b5a-4263cf699db6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EndGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_Move = m_PlayerAction.FindAction("Move", throwIfNotFound: true);
        m_PlayerAction_Reaction_A = m_PlayerAction.FindAction("Reaction_A", throwIfNotFound: true);
        m_PlayerAction_Reaction_B = m_PlayerAction.FindAction("Reaction_B", throwIfNotFound: true);
        // CameraAction
        m_CameraAction = asset.FindActionMap("CameraAction", throwIfNotFound: true);
        m_CameraAction_Rotation = m_CameraAction.FindAction("Rotation", throwIfNotFound: true);
        m_CameraAction_Updown = m_CameraAction.FindAction("Updown", throwIfNotFound: true);
        m_CameraAction_Reset = m_CameraAction.FindAction("Reset", throwIfNotFound: true);
        // SystemAction
        m_SystemAction = asset.FindActionMap("SystemAction", throwIfNotFound: true);
        m_SystemAction_EndGame = m_SystemAction.FindAction("EndGame", throwIfNotFound: true);
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

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_Move;
    private readonly InputAction m_PlayerAction_Reaction_A;
    private readonly InputAction m_PlayerAction_Reaction_B;
    public struct PlayerActionActions
    {
        private @Actions m_Wrapper;
        public PlayerActionActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerAction_Move;
        public InputAction @Reaction_A => m_Wrapper.m_PlayerAction_Reaction_A;
        public InputAction @Reaction_B => m_Wrapper.m_PlayerAction_Reaction_B;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Reaction_A.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_A;
                @Reaction_A.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_A;
                @Reaction_A.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_A;
                @Reaction_B.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_B;
                @Reaction_B.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_B;
                @Reaction_B.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnReaction_B;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Reaction_A.started += instance.OnReaction_A;
                @Reaction_A.performed += instance.OnReaction_A;
                @Reaction_A.canceled += instance.OnReaction_A;
                @Reaction_B.started += instance.OnReaction_B;
                @Reaction_B.performed += instance.OnReaction_B;
                @Reaction_B.canceled += instance.OnReaction_B;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);

    // CameraAction
    private readonly InputActionMap m_CameraAction;
    private ICameraActionActions m_CameraActionActionsCallbackInterface;
    private readonly InputAction m_CameraAction_Rotation;
    private readonly InputAction m_CameraAction_Updown;
    private readonly InputAction m_CameraAction_Reset;
    public struct CameraActionActions
    {
        private @Actions m_Wrapper;
        public CameraActionActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_CameraAction_Rotation;
        public InputAction @Updown => m_Wrapper.m_CameraAction_Updown;
        public InputAction @Reset => m_Wrapper.m_CameraAction_Reset;
        public InputActionMap Get() { return m_Wrapper.m_CameraAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActionActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActionActions instance)
        {
            if (m_Wrapper.m_CameraActionActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotation;
                @Updown.started -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnUpdown;
                @Updown.performed -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnUpdown;
                @Updown.canceled -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnUpdown;
                @Reset.started -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_CameraActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Updown.started += instance.OnUpdown;
                @Updown.performed += instance.OnUpdown;
                @Updown.canceled += instance.OnUpdown;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public CameraActionActions @CameraAction => new CameraActionActions(this);

    // SystemAction
    private readonly InputActionMap m_SystemAction;
    private ISystemActionActions m_SystemActionActionsCallbackInterface;
    private readonly InputAction m_SystemAction_EndGame;
    public struct SystemActionActions
    {
        private @Actions m_Wrapper;
        public SystemActionActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @EndGame => m_Wrapper.m_SystemAction_EndGame;
        public InputActionMap Get() { return m_Wrapper.m_SystemAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SystemActionActions set) { return set.Get(); }
        public void SetCallbacks(ISystemActionActions instance)
        {
            if (m_Wrapper.m_SystemActionActionsCallbackInterface != null)
            {
                @EndGame.started -= m_Wrapper.m_SystemActionActionsCallbackInterface.OnEndGame;
                @EndGame.performed -= m_Wrapper.m_SystemActionActionsCallbackInterface.OnEndGame;
                @EndGame.canceled -= m_Wrapper.m_SystemActionActionsCallbackInterface.OnEndGame;
            }
            m_Wrapper.m_SystemActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EndGame.started += instance.OnEndGame;
                @EndGame.performed += instance.OnEndGame;
                @EndGame.canceled += instance.OnEndGame;
            }
        }
    }
    public SystemActionActions @SystemAction => new SystemActionActions(this);
    public interface IPlayerActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnReaction_A(InputAction.CallbackContext context);
        void OnReaction_B(InputAction.CallbackContext context);
    }
    public interface ICameraActionActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnUpdown(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
    public interface ISystemActionActions
    {
        void OnEndGame(InputAction.CallbackContext context);
    }
}
