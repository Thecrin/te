//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Controles/Control_Sonic.inputactions
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

public partial class @Control_Sonic : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control_Sonic()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control_Sonic"",
    ""maps"": [
        {
            ""name"": ""Sonic_estandar"",
            ""id"": ""8cfea3f0-e0f6-4648-892d-05dcfbe009fc"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""1db33ba9-d3e5-420c-9c78-3eb3ace87cce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""ed41fde8-6bc0-4b4c-a766-d139f06d7e82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""b060058f-af5a-40d8-a530-070e1dfd091a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""43b26029-0797-4ea9-8d4c-c6fdd54b777b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Carte"",
                    ""type"": ""Value"",
                    ""id"": ""5c492c1a-0f34-4792-98a0-ff9627b967c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""J_I"",
                    ""type"": ""Value"",
                    ""id"": ""708c5bdc-aa47-48f7-9e5c-fe411512112b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""J_D"",
                    ""type"": ""Value"",
                    ""id"": ""171b24da-1e36-4e96-9300-45abb22b6965"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""mas"",
                    ""type"": ""Button"",
                    ""id"": ""64883a42-defb-4d11-8052-83b691a08140"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""menos"",
                    ""type"": ""Button"",
                    ""id"": ""d7957b33-7ff0-4e80-a2e7-44f7433e3f2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lal"",
                    ""type"": ""Button"",
                    ""id"": ""b9f205e9-30b6-4060-af54-f631183ccace"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lel"",
                    ""type"": ""Button"",
                    ""id"": ""0fcf8b29-f4f5-4e37-ba9c-a0e71cfe3251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lil"",
                    ""type"": ""Button"",
                    ""id"": ""af081162-8863-447b-b376-51de69c44a6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lol"",
                    ""type"": ""Button"",
                    ""id"": ""7f032a7a-a4c9-4daf-8551-5724fe1168c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""J_PI"",
                    ""type"": ""Button"",
                    ""id"": ""732a666c-08c0-43a3-9ec4-d4b3bf4628d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""J_PD"",
                    ""type"": ""Button"",
                    ""id"": ""f5fe9a57-93bc-483a-ac1e-126293f5d956"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""679c892d-3c30-48f0-9c99-72e22eae117a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bb4adc3-9bb1-4e4f-80cd-be80442e68a2"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06fdfd83-696e-4dbe-a843-25738fb8a5c1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ae7c4f8-9ed0-484b-9bb4-a874d0219fa8"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce63be7f-08f9-4fe5-ae25-554f1c66ae28"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c803e9fd-2f52-4df3-9460-5c6ec3ab0d03"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bcff5b9-8443-4f86-afad-0c3d28ef6024"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce7f9b9-fe08-4547-b3bb-cb3dd301a87d"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Carte"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b986f19-3ab6-4e98-9d7f-85133b8ad0ac"",
                    ""path"": ""<XInputController>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Carte"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""901de733-d6b4-4ee9-9ea7-41b615d990df"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_I"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47bb5aa3-3529-4ae9-88c4-2daaf51a6d31"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_I"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b4cb999-8721-41ae-9d8e-88245f0ce405"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c731674c-cc1a-494c-a145-a133083feda3"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8751c096-4702-45e7-ad75-650ea17d195d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""210570e9-9211-4132-ba3c-75d45a6e4015"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bca93af-cd40-4f95-b793-e7f266470d41"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9603bdf3-682b-43dd-a732-86923170e87b"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43bb9e23-b31a-492a-b874-f961419accc9"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa09af98-815a-4ce0-8930-25a3282c6267"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75320140-4d10-4ac8-a4e1-bfe44dad4bae"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df0b4e8-05c1-401f-8f9c-7f6e6998df77"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daa6326a-465f-47ec-b3a7-b014794f638a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lil"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6be6293c-5361-4f94-8d31-73204629bb02"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lil"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e29e9792-8e39-4e9d-8a32-fd211fa4a57b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c40dc602-f2cb-4e1a-a85a-1dd6f9901008"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e0eeca7-ecf8-478c-b012-313ed5c7d9ee"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_PI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8e25924-f1c2-45f4-b983-f13a62b2382f"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_PI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0fe955b-7cb5-43e5-b201-078ed20d9b8c"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_PD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57796d77-5682-4e0f-b35e-c91a3b734e2f"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J_PD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Sonic_estandar
        m_Sonic_estandar = asset.FindActionMap("Sonic_estandar", throwIfNotFound: true);
        m_Sonic_estandar_A = m_Sonic_estandar.FindAction("A", throwIfNotFound: true);
        m_Sonic_estandar_B = m_Sonic_estandar.FindAction("B", throwIfNotFound: true);
        m_Sonic_estandar_Y = m_Sonic_estandar.FindAction("Y", throwIfNotFound: true);
        m_Sonic_estandar_X = m_Sonic_estandar.FindAction("X", throwIfNotFound: true);
        m_Sonic_estandar_Carte = m_Sonic_estandar.FindAction("Carte", throwIfNotFound: true);
        m_Sonic_estandar_J_I = m_Sonic_estandar.FindAction("J_I", throwIfNotFound: true);
        m_Sonic_estandar_J_D = m_Sonic_estandar.FindAction("J_D", throwIfNotFound: true);
        m_Sonic_estandar_mas = m_Sonic_estandar.FindAction("mas", throwIfNotFound: true);
        m_Sonic_estandar_menos = m_Sonic_estandar.FindAction("menos", throwIfNotFound: true);
        m_Sonic_estandar_lal = m_Sonic_estandar.FindAction("lal", throwIfNotFound: true);
        m_Sonic_estandar_lel = m_Sonic_estandar.FindAction("lel", throwIfNotFound: true);
        m_Sonic_estandar_lil = m_Sonic_estandar.FindAction("lil", throwIfNotFound: true);
        m_Sonic_estandar_lol = m_Sonic_estandar.FindAction("lol", throwIfNotFound: true);
        m_Sonic_estandar_J_PI = m_Sonic_estandar.FindAction("J_PI", throwIfNotFound: true);
        m_Sonic_estandar_J_PD = m_Sonic_estandar.FindAction("J_PD", throwIfNotFound: true);
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

    // Sonic_estandar
    private readonly InputActionMap m_Sonic_estandar;
    private ISonic_estandarActions m_Sonic_estandarActionsCallbackInterface;
    private readonly InputAction m_Sonic_estandar_A;
    private readonly InputAction m_Sonic_estandar_B;
    private readonly InputAction m_Sonic_estandar_Y;
    private readonly InputAction m_Sonic_estandar_X;
    private readonly InputAction m_Sonic_estandar_Carte;
    private readonly InputAction m_Sonic_estandar_J_I;
    private readonly InputAction m_Sonic_estandar_J_D;
    private readonly InputAction m_Sonic_estandar_mas;
    private readonly InputAction m_Sonic_estandar_menos;
    private readonly InputAction m_Sonic_estandar_lal;
    private readonly InputAction m_Sonic_estandar_lel;
    private readonly InputAction m_Sonic_estandar_lil;
    private readonly InputAction m_Sonic_estandar_lol;
    private readonly InputAction m_Sonic_estandar_J_PI;
    private readonly InputAction m_Sonic_estandar_J_PD;
    public struct Sonic_estandarActions
    {
        private @Control_Sonic m_Wrapper;
        public Sonic_estandarActions(@Control_Sonic wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Sonic_estandar_A;
        public InputAction @B => m_Wrapper.m_Sonic_estandar_B;
        public InputAction @Y => m_Wrapper.m_Sonic_estandar_Y;
        public InputAction @X => m_Wrapper.m_Sonic_estandar_X;
        public InputAction @Carte => m_Wrapper.m_Sonic_estandar_Carte;
        public InputAction @J_I => m_Wrapper.m_Sonic_estandar_J_I;
        public InputAction @J_D => m_Wrapper.m_Sonic_estandar_J_D;
        public InputAction @mas => m_Wrapper.m_Sonic_estandar_mas;
        public InputAction @menos => m_Wrapper.m_Sonic_estandar_menos;
        public InputAction @lal => m_Wrapper.m_Sonic_estandar_lal;
        public InputAction @lel => m_Wrapper.m_Sonic_estandar_lel;
        public InputAction @lil => m_Wrapper.m_Sonic_estandar_lil;
        public InputAction @lol => m_Wrapper.m_Sonic_estandar_lol;
        public InputAction @J_PI => m_Wrapper.m_Sonic_estandar_J_PI;
        public InputAction @J_PD => m_Wrapper.m_Sonic_estandar_J_PD;
        public InputActionMap Get() { return m_Wrapper.m_Sonic_estandar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Sonic_estandarActions set) { return set.Get(); }
        public void SetCallbacks(ISonic_estandarActions instance)
        {
            if (m_Wrapper.m_Sonic_estandarActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnB;
                @Y.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnY;
                @X.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnX;
                @Carte.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnCarte;
                @Carte.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnCarte;
                @Carte.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnCarte;
                @J_I.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_I;
                @J_I.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_I;
                @J_I.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_I;
                @J_D.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_D;
                @J_D.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_D;
                @J_D.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_D;
                @mas.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMas;
                @mas.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMas;
                @mas.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMas;
                @menos.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMenos;
                @menos.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMenos;
                @menos.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnMenos;
                @lal.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLal;
                @lal.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLal;
                @lal.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLal;
                @lel.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLel;
                @lel.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLel;
                @lel.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLel;
                @lil.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLil;
                @lil.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLil;
                @lil.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLil;
                @lol.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLol;
                @lol.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLol;
                @lol.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnLol;
                @J_PI.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PI;
                @J_PI.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PI;
                @J_PI.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PI;
                @J_PD.started -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PD;
                @J_PD.performed -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PD;
                @J_PD.canceled -= m_Wrapper.m_Sonic_estandarActionsCallbackInterface.OnJ_PD;
            }
            m_Wrapper.m_Sonic_estandarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Carte.started += instance.OnCarte;
                @Carte.performed += instance.OnCarte;
                @Carte.canceled += instance.OnCarte;
                @J_I.started += instance.OnJ_I;
                @J_I.performed += instance.OnJ_I;
                @J_I.canceled += instance.OnJ_I;
                @J_D.started += instance.OnJ_D;
                @J_D.performed += instance.OnJ_D;
                @J_D.canceled += instance.OnJ_D;
                @mas.started += instance.OnMas;
                @mas.performed += instance.OnMas;
                @mas.canceled += instance.OnMas;
                @menos.started += instance.OnMenos;
                @menos.performed += instance.OnMenos;
                @menos.canceled += instance.OnMenos;
                @lal.started += instance.OnLal;
                @lal.performed += instance.OnLal;
                @lal.canceled += instance.OnLal;
                @lel.started += instance.OnLel;
                @lel.performed += instance.OnLel;
                @lel.canceled += instance.OnLel;
                @lil.started += instance.OnLil;
                @lil.performed += instance.OnLil;
                @lil.canceled += instance.OnLil;
                @lol.started += instance.OnLol;
                @lol.performed += instance.OnLol;
                @lol.canceled += instance.OnLol;
                @J_PI.started += instance.OnJ_PI;
                @J_PI.performed += instance.OnJ_PI;
                @J_PI.canceled += instance.OnJ_PI;
                @J_PD.started += instance.OnJ_PD;
                @J_PD.performed += instance.OnJ_PD;
                @J_PD.canceled += instance.OnJ_PD;
            }
        }
    }
    public Sonic_estandarActions @Sonic_estandar => new Sonic_estandarActions(this);
    public interface ISonic_estandarActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnCarte(InputAction.CallbackContext context);
        void OnJ_I(InputAction.CallbackContext context);
        void OnJ_D(InputAction.CallbackContext context);
        void OnMas(InputAction.CallbackContext context);
        void OnMenos(InputAction.CallbackContext context);
        void OnLal(InputAction.CallbackContext context);
        void OnLel(InputAction.CallbackContext context);
        void OnLil(InputAction.CallbackContext context);
        void OnLol(InputAction.CallbackContext context);
        void OnJ_PI(InputAction.CallbackContext context);
        void OnJ_PD(InputAction.CallbackContext context);
    }
}
