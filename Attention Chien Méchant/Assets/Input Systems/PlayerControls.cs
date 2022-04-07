// GENERATED AUTOMATICALLY FROM 'Assets/Input Systems/PlayerControls.inputactions'

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
            ""name"": ""Player (Multiple Controllers)"",
            ""id"": ""3284114b-d481-4572-bda9-705387d4521a"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""2c17ec4f-bfda-4e4a-8f3d-8034a47ff4fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""1c103f23-cf69-4eae-8b36-41a34d35af36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""feab0a1b-56f1-4dd0-aeed-3ea3b3a9e8cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""892b9869-435e-4081-9424-536c1a477971"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bark"",
                    ""type"": ""Button"",
                    ""id"": ""ae619051-efb8-4cbc-a5ef-0ee2edb317ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cbf5e03d-338d-40ef-8a6e-9411a9606e48"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30e05747-3c7a-464f-bef2-c006d966a51a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae70e183-2334-4b11-9e2e-b5a8cb266fd0"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3908f9a-78ec-44f9-b8bc-7745d623346b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f931478-e045-42c9-84db-7eb6316909ba"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc9767e-4e3e-40c5-8240-1de54dae108a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6ef0295-84ee-429a-84f5-af88657ecf03"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a20205f-c42f-4c42-affe-075c90012ae8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66da5677-ee01-47bf-ab83-5d0cdbb090e5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34cccfd2-c71a-48c8-a786-49ac0dd5d9f4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player (Keyboard)"",
            ""id"": ""aa031e35-8623-49dc-be71-c9dd93c38289"",
            ""actions"": [
                {
                    ""name"": ""Mailman Up"",
                    ""type"": ""Button"",
                    ""id"": ""4f7c0949-a345-4f4a-bb24-6bcb13550d78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mailman Down"",
                    ""type"": ""Button"",
                    ""id"": ""f0717517-0b46-4bc9-bbbc-9593701b7688"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mailman Left"",
                    ""type"": ""Button"",
                    ""id"": ""beb62b23-2120-4c0c-b3de-8cc8c5aa8505"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mailman Right"",
                    ""type"": ""Button"",
                    ""id"": ""512b8c4d-d434-4871-a927-83b15c70a9fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dog Up"",
                    ""type"": ""Button"",
                    ""id"": ""c61772cb-423a-4156-9f35-9b9dc9a09661"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dog Down"",
                    ""type"": ""Button"",
                    ""id"": ""6cf5c594-e47f-423f-bceb-01463a0ae9d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dog Left"",
                    ""type"": ""Button"",
                    ""id"": ""bf531c03-5c85-4650-a098-d2cb8d9dbb33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dog Right"",
                    ""type"": ""Button"",
                    ""id"": ""3f6a0458-44b8-4ed8-8660-cca9d56727e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dog Bark"",
                    ""type"": ""Button"",
                    ""id"": ""bd1a5d35-c8d2-4b30-bcda-ce2c29f6c5d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7a6223cc-b7df-452d-b0a2-26e535e47559"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mailman Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f862077-79be-4f89-ad7a-ef4321420446"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mailman Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80bf552d-86b7-4d9f-9eee-2fc6827a2379"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mailman Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbfc8bfe-0645-4ae0-a11d-bd9947f18d60"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mailman Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""664fd318-19b3-4c7d-8cf3-b89218f1636e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dog Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac2ffc4b-cb49-4158-ba6b-f99dc9802d8b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dog Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a93dd69f-be62-4443-bf43-3fcd0286117d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dog Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a34b5c93-1290-4e2a-9058-9cd3564372f3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dog Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""103e6169-9cba-4768-a550-5cc31a22a08c"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dog Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player (Multiple Controllers)
        m_PlayerMultipleControllers = asset.FindActionMap("Player (Multiple Controllers)", throwIfNotFound: true);
        m_PlayerMultipleControllers_Up = m_PlayerMultipleControllers.FindAction("Up", throwIfNotFound: true);
        m_PlayerMultipleControllers_Down = m_PlayerMultipleControllers.FindAction("Down", throwIfNotFound: true);
        m_PlayerMultipleControllers_Left = m_PlayerMultipleControllers.FindAction("Left", throwIfNotFound: true);
        m_PlayerMultipleControllers_Right = m_PlayerMultipleControllers.FindAction("Right", throwIfNotFound: true);
        m_PlayerMultipleControllers_Bark = m_PlayerMultipleControllers.FindAction("Bark", throwIfNotFound: true);
        // Player (Keyboard)
        m_PlayerKeyboard = asset.FindActionMap("Player (Keyboard)", throwIfNotFound: true);
        m_PlayerKeyboard_MailmanUp = m_PlayerKeyboard.FindAction("Mailman Up", throwIfNotFound: true);
        m_PlayerKeyboard_MailmanDown = m_PlayerKeyboard.FindAction("Mailman Down", throwIfNotFound: true);
        m_PlayerKeyboard_MailmanLeft = m_PlayerKeyboard.FindAction("Mailman Left", throwIfNotFound: true);
        m_PlayerKeyboard_MailmanRight = m_PlayerKeyboard.FindAction("Mailman Right", throwIfNotFound: true);
        m_PlayerKeyboard_DogUp = m_PlayerKeyboard.FindAction("Dog Up", throwIfNotFound: true);
        m_PlayerKeyboard_DogDown = m_PlayerKeyboard.FindAction("Dog Down", throwIfNotFound: true);
        m_PlayerKeyboard_DogLeft = m_PlayerKeyboard.FindAction("Dog Left", throwIfNotFound: true);
        m_PlayerKeyboard_DogRight = m_PlayerKeyboard.FindAction("Dog Right", throwIfNotFound: true);
        m_PlayerKeyboard_DogBark = m_PlayerKeyboard.FindAction("Dog Bark", throwIfNotFound: true);
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

    // Player (Multiple Controllers)
    private readonly InputActionMap m_PlayerMultipleControllers;
    private IPlayerMultipleControllersActions m_PlayerMultipleControllersActionsCallbackInterface;
    private readonly InputAction m_PlayerMultipleControllers_Up;
    private readonly InputAction m_PlayerMultipleControllers_Down;
    private readonly InputAction m_PlayerMultipleControllers_Left;
    private readonly InputAction m_PlayerMultipleControllers_Right;
    private readonly InputAction m_PlayerMultipleControllers_Bark;
    public struct PlayerMultipleControllersActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMultipleControllersActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_PlayerMultipleControllers_Up;
        public InputAction @Down => m_Wrapper.m_PlayerMultipleControllers_Down;
        public InputAction @Left => m_Wrapper.m_PlayerMultipleControllers_Left;
        public InputAction @Right => m_Wrapper.m_PlayerMultipleControllers_Right;
        public InputAction @Bark => m_Wrapper.m_PlayerMultipleControllers_Bark;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMultipleControllers; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMultipleControllersActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMultipleControllersActions instance)
        {
            if (m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnRight;
                @Bark.started -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnBark;
                @Bark.performed -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnBark;
                @Bark.canceled -= m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface.OnBark;
            }
            m_Wrapper.m_PlayerMultipleControllersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Bark.started += instance.OnBark;
                @Bark.performed += instance.OnBark;
                @Bark.canceled += instance.OnBark;
            }
        }
    }
    public PlayerMultipleControllersActions @PlayerMultipleControllers => new PlayerMultipleControllersActions(this);

    // Player (Keyboard)
    private readonly InputActionMap m_PlayerKeyboard;
    private IPlayerKeyboardActions m_PlayerKeyboardActionsCallbackInterface;
    private readonly InputAction m_PlayerKeyboard_MailmanUp;
    private readonly InputAction m_PlayerKeyboard_MailmanDown;
    private readonly InputAction m_PlayerKeyboard_MailmanLeft;
    private readonly InputAction m_PlayerKeyboard_MailmanRight;
    private readonly InputAction m_PlayerKeyboard_DogUp;
    private readonly InputAction m_PlayerKeyboard_DogDown;
    private readonly InputAction m_PlayerKeyboard_DogLeft;
    private readonly InputAction m_PlayerKeyboard_DogRight;
    private readonly InputAction m_PlayerKeyboard_DogBark;
    public struct PlayerKeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerKeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MailmanUp => m_Wrapper.m_PlayerKeyboard_MailmanUp;
        public InputAction @MailmanDown => m_Wrapper.m_PlayerKeyboard_MailmanDown;
        public InputAction @MailmanLeft => m_Wrapper.m_PlayerKeyboard_MailmanLeft;
        public InputAction @MailmanRight => m_Wrapper.m_PlayerKeyboard_MailmanRight;
        public InputAction @DogUp => m_Wrapper.m_PlayerKeyboard_DogUp;
        public InputAction @DogDown => m_Wrapper.m_PlayerKeyboard_DogDown;
        public InputAction @DogLeft => m_Wrapper.m_PlayerKeyboard_DogLeft;
        public InputAction @DogRight => m_Wrapper.m_PlayerKeyboard_DogRight;
        public InputAction @DogBark => m_Wrapper.m_PlayerKeyboard_DogBark;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKeyboardActions instance)
        {
            if (m_Wrapper.m_PlayerKeyboardActionsCallbackInterface != null)
            {
                @MailmanUp.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanUp;
                @MailmanUp.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanUp;
                @MailmanUp.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanUp;
                @MailmanDown.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanDown;
                @MailmanDown.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanDown;
                @MailmanDown.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanDown;
                @MailmanLeft.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanLeft;
                @MailmanLeft.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanLeft;
                @MailmanLeft.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanLeft;
                @MailmanRight.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanRight;
                @MailmanRight.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanRight;
                @MailmanRight.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnMailmanRight;
                @DogUp.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogUp;
                @DogUp.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogUp;
                @DogUp.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogUp;
                @DogDown.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogDown;
                @DogDown.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogDown;
                @DogDown.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogDown;
                @DogLeft.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogLeft;
                @DogLeft.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogLeft;
                @DogLeft.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogLeft;
                @DogRight.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogRight;
                @DogRight.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogRight;
                @DogRight.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogRight;
                @DogBark.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogBark;
                @DogBark.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogBark;
                @DogBark.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnDogBark;
            }
            m_Wrapper.m_PlayerKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MailmanUp.started += instance.OnMailmanUp;
                @MailmanUp.performed += instance.OnMailmanUp;
                @MailmanUp.canceled += instance.OnMailmanUp;
                @MailmanDown.started += instance.OnMailmanDown;
                @MailmanDown.performed += instance.OnMailmanDown;
                @MailmanDown.canceled += instance.OnMailmanDown;
                @MailmanLeft.started += instance.OnMailmanLeft;
                @MailmanLeft.performed += instance.OnMailmanLeft;
                @MailmanLeft.canceled += instance.OnMailmanLeft;
                @MailmanRight.started += instance.OnMailmanRight;
                @MailmanRight.performed += instance.OnMailmanRight;
                @MailmanRight.canceled += instance.OnMailmanRight;
                @DogUp.started += instance.OnDogUp;
                @DogUp.performed += instance.OnDogUp;
                @DogUp.canceled += instance.OnDogUp;
                @DogDown.started += instance.OnDogDown;
                @DogDown.performed += instance.OnDogDown;
                @DogDown.canceled += instance.OnDogDown;
                @DogLeft.started += instance.OnDogLeft;
                @DogLeft.performed += instance.OnDogLeft;
                @DogLeft.canceled += instance.OnDogLeft;
                @DogRight.started += instance.OnDogRight;
                @DogRight.performed += instance.OnDogRight;
                @DogRight.canceled += instance.OnDogRight;
                @DogBark.started += instance.OnDogBark;
                @DogBark.performed += instance.OnDogBark;
                @DogBark.canceled += instance.OnDogBark;
            }
        }
    }
    public PlayerKeyboardActions @PlayerKeyboard => new PlayerKeyboardActions(this);
    public interface IPlayerMultipleControllersActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnBark(InputAction.CallbackContext context);
    }
    public interface IPlayerKeyboardActions
    {
        void OnMailmanUp(InputAction.CallbackContext context);
        void OnMailmanDown(InputAction.CallbackContext context);
        void OnMailmanLeft(InputAction.CallbackContext context);
        void OnMailmanRight(InputAction.CallbackContext context);
        void OnDogUp(InputAction.CallbackContext context);
        void OnDogDown(InputAction.CallbackContext context);
        void OnDogLeft(InputAction.CallbackContext context);
        void OnDogRight(InputAction.CallbackContext context);
        void OnDogBark(InputAction.CallbackContext context);
    }
}
