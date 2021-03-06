//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/scripts/controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""19d58b3f-6028-4991-979e-ae95d61d581f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e3ccaac7-27e1-41d8-9283-c38f4a20dd73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""605630f8-ce8d-4a2c-91bb-ac8ed4251404"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""53a32a64-b9fc-4ddf-9020-ce9a28082bb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LB"",
                    ""type"": ""Button"",
                    ""id"": ""8f3c6876-a451-4993-b414-2176889f0254"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.5)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RBB"",
                    ""type"": ""Button"",
                    ""id"": ""c19ed8c5-2635-4cc8-b0d5-445de4b4a197"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LBB"",
                    ""type"": ""Button"",
                    ""id"": ""783de8b1-80a6-402f-a259-1bee63518447"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""cross"",
                    ""type"": ""Button"",
                    ""id"": ""caaeb8d5-7d0c-43a1-90e9-f9726843f9bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""circle"",
                    ""type"": ""Button"",
                    ""id"": ""4562e9fd-9166-4735-a59b-5bf0f66d5e0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""up"",
                    ""type"": ""Button"",
                    ""id"": ""9dfcc7a8-15c1-4122-83b8-132e4ef29ab4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""right"",
                    ""type"": ""Button"",
                    ""id"": ""dd77fed0-96cc-4c43-9839-d3b6465cd325"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""down"",
                    ""type"": ""Button"",
                    ""id"": ""8dda6096-0408-4817-add5-c61f54076525"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""left"",
                    ""type"": ""Button"",
                    ""id"": ""682dd4d3-97b3-4c85-ba2a-b1396c6ed582"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a17b4564-072f-4515-adda-1243e51e5de8"",
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
                    ""id"": ""c72dd6c3-0bae-499f-a532-3f554a053559"",
                    ""path"": ""<Gamepad>/rightStick/"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f06f320-e728-4143-bf4a-27af13b83f73"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72ffb2d4-5838-4125-b107-21b86bfe1e3c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ef6278f-0ea8-4e8e-a6d3-898c9c1bda06"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RBB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5071a65d-3239-4a6d-b9ea-028518af67e0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff06f194-8032-4e1b-a60e-8b6475de04dd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""319fa586-593e-4f37-b340-38f2e04ea1b4"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joistick"",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""148fafd4-97c4-43b2-baa5-df3c5bf7563b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joistick"",
                    ""action"": ""right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""802707cc-f7ad-4382-82be-4cd7d2fcc647"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joistick"",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cea0808a-2a31-4089-8b0b-1e63cddae11d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joistick"",
                    ""action"": ""left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a09f186e-8215-4372-8e59-27a0ba698c9d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LBB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Joistick"",
            ""bindingGroup"": ""Joistick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        m_Gameplay_RB = m_Gameplay.FindAction("RB", throwIfNotFound: true);
        m_Gameplay_LB = m_Gameplay.FindAction("LB", throwIfNotFound: true);
        m_Gameplay_RBB = m_Gameplay.FindAction("RBB", throwIfNotFound: true);
        m_Gameplay_LBB = m_Gameplay.FindAction("LBB", throwIfNotFound: true);
        m_Gameplay_cross = m_Gameplay.FindAction("cross", throwIfNotFound: true);
        m_Gameplay_circle = m_Gameplay.FindAction("circle", throwIfNotFound: true);
        m_Gameplay_up = m_Gameplay.FindAction("up", throwIfNotFound: true);
        m_Gameplay_right = m_Gameplay.FindAction("right", throwIfNotFound: true);
        m_Gameplay_down = m_Gameplay.FindAction("down", throwIfNotFound: true);
        m_Gameplay_left = m_Gameplay.FindAction("left", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    private readonly InputAction m_Gameplay_RB;
    private readonly InputAction m_Gameplay_LB;
    private readonly InputAction m_Gameplay_RBB;
    private readonly InputAction m_Gameplay_LBB;
    private readonly InputAction m_Gameplay_cross;
    private readonly InputAction m_Gameplay_circle;
    private readonly InputAction m_Gameplay_up;
    private readonly InputAction m_Gameplay_right;
    private readonly InputAction m_Gameplay_down;
    private readonly InputAction m_Gameplay_left;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputAction @RB => m_Wrapper.m_Gameplay_RB;
        public InputAction @LB => m_Wrapper.m_Gameplay_LB;
        public InputAction @RBB => m_Wrapper.m_Gameplay_RBB;
        public InputAction @LBB => m_Wrapper.m_Gameplay_LBB;
        public InputAction @cross => m_Wrapper.m_Gameplay_cross;
        public InputAction @circle => m_Wrapper.m_Gameplay_circle;
        public InputAction @up => m_Wrapper.m_Gameplay_up;
        public InputAction @right => m_Wrapper.m_Gameplay_right;
        public InputAction @down => m_Wrapper.m_Gameplay_down;
        public InputAction @left => m_Wrapper.m_Gameplay_left;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @RB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRB;
                @LB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLB;
                @LB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLB;
                @LB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLB;
                @RBB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBB;
                @RBB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBB;
                @RBB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBB;
                @LBB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBB;
                @LBB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBB;
                @LBB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBB;
                @cross.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCross;
                @cross.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCross;
                @cross.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCross;
                @circle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @circle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @circle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCircle;
                @up.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUp;
                @up.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUp;
                @up.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUp;
                @right.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @right.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @right.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight;
                @down.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDown;
                @down.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDown;
                @down.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDown;
                @left.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @left.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @left.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @LB.started += instance.OnLB;
                @LB.performed += instance.OnLB;
                @LB.canceled += instance.OnLB;
                @RBB.started += instance.OnRBB;
                @RBB.performed += instance.OnRBB;
                @RBB.canceled += instance.OnRBB;
                @LBB.started += instance.OnLBB;
                @LBB.performed += instance.OnLBB;
                @LBB.canceled += instance.OnLBB;
                @cross.started += instance.OnCross;
                @cross.performed += instance.OnCross;
                @cross.canceled += instance.OnCross;
                @circle.started += instance.OnCircle;
                @circle.performed += instance.OnCircle;
                @circle.canceled += instance.OnCircle;
                @up.started += instance.OnUp;
                @up.performed += instance.OnUp;
                @up.canceled += instance.OnUp;
                @right.started += instance.OnRight;
                @right.performed += instance.OnRight;
                @right.canceled += instance.OnRight;
                @down.started += instance.OnDown;
                @down.performed += instance.OnDown;
                @down.canceled += instance.OnDown;
                @left.started += instance.OnLeft;
                @left.performed += instance.OnLeft;
                @left.canceled += instance.OnLeft;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_JoistickSchemeIndex = -1;
    public InputControlScheme JoistickScheme
    {
        get
        {
            if (m_JoistickSchemeIndex == -1) m_JoistickSchemeIndex = asset.FindControlSchemeIndex("Joistick");
            return asset.controlSchemes[m_JoistickSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnLB(InputAction.CallbackContext context);
        void OnRBB(InputAction.CallbackContext context);
        void OnLBB(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
    }
}
