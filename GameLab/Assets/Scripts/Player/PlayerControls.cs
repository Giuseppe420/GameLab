//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""c40d34d5-ddaa-4932-81a7-265b571b5f6e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""04a47717-d0f2-4616-a510-ebff9a7e5c85"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""57c825ca-067f-4118-a8f9-a59800346405"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""3e0ec811-8cad-4395-a3b9-0769b5e951dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e2a1d6be-96a9-437f-8563-483cd1cec215"",
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
                    ""id"": ""97058831-61ff-4a0f-a41d-98e516796a97"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e757c55-4ae9-4db8-80a4-b106b9515c97"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""19ab3c67-a400-432e-9dd1-b31a843d76c7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3252dfe2-e5cb-477b-b9b8-4a9971f92475"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
<<<<<<< HEAD
<<<<<<< HEAD
                    ""id"": ""2f37385a-ee2e-4f7a-8f95-5410a5c4c685"",
=======
                    ""id"": ""417f90f5-2de6-4610-86f5-b6efbe1f7261"",
>>>>>>> parent of 4b8cf44 (Change the schemes)
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
=======
>>>>>>> parent of de60e79 (Local coop developed)
                    ""id"": ""c9bbfe9b-da81-4fd5-bfa6-8345c2f84937"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< HEAD
<<<<<<< HEAD
                    ""id"": ""53745ea8-a2e6-43bd-b7e5-a40efab54730"",
=======
                    ""id"": ""8f6f31cb-c658-48e3-a711-a1fc2845a301"",
>>>>>>> parent of 4b8cf44 (Change the schemes)
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
=======
>>>>>>> parent of de60e79 (Local coop developed)
                    ""id"": ""4b654e2d-e669-488c-a83c-40ea6ba0ef54"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
<<<<<<< HEAD
                },
                {
                    ""name"": """",
                    ""id"": ""11d94e05-d2dc-418d-a99f-74995658c4c7"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""547198bb-e992-43b6-8b42-e5c1670ef344"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
=======
>>>>>>> parent of de60e79 (Local coop developed)
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
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
<<<<<<< HEAD
<<<<<<< HEAD
                },
=======
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
>>>>>>> parent of 4b8cf44 (Change the schemes)
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
=======
>>>>>>> parent of de60e79 (Local coop developed)
                }
            ]
        }
    ]
}");
<<<<<<< HEAD
<<<<<<< HEAD
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Move = m_Default.FindAction("Move", throwIfNotFound: true);
        m_Default_Jump = m_Default.FindAction("Jump", throwIfNotFound: true);
        m_Default_Duck = m_Default.FindAction("Duck", throwIfNotFound: true);
        m_Default_Join = m_Default.FindAction("Join", throwIfNotFound: true);
=======
=======
>>>>>>> parent of 4b8cf44 (Change the schemes)
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Move = m_Game.FindAction("Move", throwIfNotFound: true);
        m_Game_Jump = m_Game.FindAction("Jump", throwIfNotFound: true);
        m_Game_Duck = m_Game.FindAction("Duck", throwIfNotFound: true);
<<<<<<< HEAD
>>>>>>> parent of de60e79 (Local coop developed)
=======
        m_Game_Join = m_Game.FindAction("Join", throwIfNotFound: true);
>>>>>>> parent of 4b8cf44 (Change the schemes)
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

<<<<<<< HEAD
<<<<<<< HEAD
    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Move;
    private readonly InputAction m_Default_Jump;
    private readonly InputAction m_Default_Duck;
    private readonly InputAction m_Default_Join;
    public struct DefaultActions
    {
        private @PlayerControls m_Wrapper;
        public DefaultActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Default_Move;
        public InputAction @Jump => m_Wrapper.m_Default_Jump;
        public InputAction @Duck => m_Wrapper.m_Default_Duck;
        public InputAction @Join => m_Wrapper.m_Default_Join;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
=======
    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Move;
    private readonly InputAction m_Game_Jump;
    private readonly InputAction m_Game_Duck;
    public struct GameActions
    {
        private @PlayerControls m_Wrapper;
=======
    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Move;
    private readonly InputAction m_Game_Jump;
    private readonly InputAction m_Game_Duck;
    private readonly InputAction m_Game_Join;
    public struct GameActions
    {
        private @PlayerControls m_Wrapper;
>>>>>>> parent of 4b8cf44 (Change the schemes)
        public GameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Game_Move;
        public InputAction @Jump => m_Wrapper.m_Game_Jump;
        public InputAction @Duck => m_Wrapper.m_Game_Duck;
<<<<<<< HEAD
        public InputActionMap Get() { return m_Wrapper.m_Game; }
>>>>>>> parent of de60e79 (Local coop developed)
=======
        public InputAction @Join => m_Wrapper.m_Game_Join;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
>>>>>>> parent of 4b8cf44 (Change the schemes)
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                @Move.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Duck.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDuck;
                @Join.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoin;
=======
=======
>>>>>>> parent of 4b8cf44 (Change the schemes)
                @Move.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnJump;
                @Duck.started -= m_Wrapper.m_GameActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnDuck;
<<<<<<< HEAD
>>>>>>> parent of de60e79 (Local coop developed)
=======
                @Join.started -= m_Wrapper.m_GameActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnJoin;
>>>>>>> parent of 4b8cf44 (Change the schemes)
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Duck.started += instance.OnDuck;
                @Duck.performed += instance.OnDuck;
                @Duck.canceled += instance.OnDuck;
            }
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
    public DefaultActions @Default => new DefaultActions(this);
    private int m_GameSchemeIndex = -1;
    public InputControlScheme GameScheme
=======
    public GameActions @Game => new GameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
>>>>>>> parent of 4b8cf44 (Change the schemes)
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
<<<<<<< HEAD
    public interface IDefaultActions
=======
    public GameActions @Game => new GameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGameActions
>>>>>>> parent of de60e79 (Local coop developed)
=======
    public interface IGameActions
>>>>>>> parent of 4b8cf44 (Change the schemes)
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDuck(InputAction.CallbackContext context);
    }
}
