// GENERATED AUTOMATICALLY FROM 'Assets/Settings/MainInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Guyl.ObjetsTrouves.Inputs
{
    public class @MainInputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MainInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputs"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""d27c31ff-0d02-41fd-84bc-48b041a9f393"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""4e22eda3-55e3-4a0d-86bf-1c5ec0366b2e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""6a601644-3903-4434-bbc9-8d363d30e0b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95aaf357-b185-42cc-833e-462022a0bb66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""896a28bc-778f-4089-a273-03a2c0a057aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8852c65-7d61-441a-bbb6-c3cd67688381"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4a57d790-ec4e-4de2-af1a-dfb88edf585a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""beaf21bf-699e-4b1a-a6ab-395c001d8e7d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""59756f9c-d680-4c8d-8774-62f9ef3c341b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""192b9e7c-1c01-4a90-a179-46da0a30654b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0148514a-0623-4eb4-ac6c-1d4eed28c6d4"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""0012c427-1e43-4101-9538-9372b753e933"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91538d4c-9743-441a-9603-1be26d300cbe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47329f9d-8941-493e-b84e-9d58bee446bc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""157ec77f-d126-4e42-837d-022ec317a87a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c60ab4e3-ac5f-4945-98d3-df8cdf772272"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""5bd16043-4f3c-497d-b759-59ec21fc0b25"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ca97cc9b-fb9b-48e3-b25c-54745ebab338"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20bb22c1-dad7-406e-9930-7606d727d62a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3a5115b-3d96-4262-b8ea-6c9e24bab052"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5686e5a4-5f99-4d3d-adac-01bfac0d0e75"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""97ddeca7-b0bc-481c-96b7-59162f55d5a0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44cb75fa-9258-43bb-977e-f3907e5bc5cc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50654cba-3ffc-4a27-9dfd-b17ed36141df"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""505b2988-53ed-422f-9a1e-34ba270f5143"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df294a35-c185-4502-85ef-4fe58721864f"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5d83805-8df1-4513-b322-95031d814dd5"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right;Gamepad"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f559661d-4363-427c-9364-e6f0bc73f07c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d53e563-b0c4-44a5-80b4-bdf20e6c03b0"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a011fa22-d835-4434-8239-d1dc57c36ae5"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Gamepad;Keyboard right"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""238a3280-7c8e-46e6-906e-011476f25a89"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf4e7c3c-1e3b-4206-b041-ceab44cf0394"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b55d9153-eeb5-4401-bb2d-1d116e9f9c2a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""602d1404-f52d-4418-a1bf-27efcea9e927"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbdbe179-c319-4a3a-aca7-7884543a4a58"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0effc87-a52a-4e3f-8aaf-4cd5e360e75d"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left;Keyboard right"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""4a1cee9d-02ee-4e17-b470-c7732868aab9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b0456017-922c-4542-95a6-3f49d591990b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interract"",
                    ""type"": ""Button"",
                    ""id"": ""334db1ee-4915-4393-8c47-b23c32b1cfe4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6df16400-3a12-409f-b9d7-6850968934ef"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""73e084e2-caef-4fd6-9b23-f15edc46abc1"",
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
                    ""id"": ""c40c502d-17c9-4811-a39a-3df01910c124"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""08b6ee47-4d37-4925-83cf-149473d9ca3f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b0944981-6335-41a5-bf30-be9c74315c1b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2bc1911-417a-45e4-bc24-273bff39a41e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""278c9862-22f7-4949-ac4c-50af14c527cb"",
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
                    ""id"": ""8ee6a23a-713e-4a42-843e-b4e9d3808efa"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2d57d415-0688-47e0-842a-9cabc5aae2dc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""652d2cd9-6ac8-451f-909b-8798c9e95f21"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19606251-80e2-406a-86c0-7de292a9276b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cc612c9f-3fb6-4db8-87d6-0b2748d50fef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Left"",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b116c98-0802-4db0-9e6f-7293b509a83f"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38dc2c5f-21f5-4146-bfda-59240f46600d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainMenu"",
            ""id"": ""e6faadfa-f315-4dbe-a9bf-52bf9fe48de6"",
            ""actions"": [
                {
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""7aa650a9-60d0-4000-a362-7f084173faa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c7f592a-bdd5-4d6a-8a2d-5ec08a5ca636"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""739ba5cb-3450-4ca0-a9b7-9a4a4903300b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard right;Keyboard Left"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a6b896a-a4d8-4d65-9b66-b22d88b48e58"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard Left"",
            ""bindingGroup"": ""Keyboard Left"",
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
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard right"",
            ""bindingGroup"": ""Keyboard right"",
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
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
            m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
            m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
            m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
            m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
            m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
            m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
            m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
            // Game
            m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
            m_Game_Move = m_Game.FindAction("Move", throwIfNotFound: true);
            m_Game_Interract = m_Game.FindAction("Interract", throwIfNotFound: true);
            // MainMenu
            m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
            m_MainMenu_Join = m_MainMenu.FindAction("Join", throwIfNotFound: true);
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

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_Navigate;
        private readonly InputAction m_UI_Submit;
        private readonly InputAction m_UI_Point;
        private readonly InputAction m_UI_Click;
        private readonly InputAction m_UI_ScrollWheel;
        private readonly InputAction m_UI_MiddleClick;
        private readonly InputAction m_UI_RightClick;
        private readonly InputAction m_UI_Cancel;
        public struct UIActions
        {
            private @MainInputs m_Wrapper;
            public UIActions(@MainInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
            public InputAction @Submit => m_Wrapper.m_UI_Submit;
            public InputAction @Point => m_Wrapper.m_UI_Point;
            public InputAction @Click => m_Wrapper.m_UI_Click;
            public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
            public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
            public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
            public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                    @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                    @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                    @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @MiddleClick.started += instance.OnMiddleClick;
                    @MiddleClick.performed += instance.OnMiddleClick;
                    @MiddleClick.canceled += instance.OnMiddleClick;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                }
            }
        }
        public UIActions @UI => new UIActions(this);

        // Game
        private readonly InputActionMap m_Game;
        private IGameActions m_GameActionsCallbackInterface;
        private readonly InputAction m_Game_Move;
        private readonly InputAction m_Game_Interract;
        public struct GameActions
        {
            private @MainInputs m_Wrapper;
            public GameActions(@MainInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Game_Move;
            public InputAction @Interract => m_Wrapper.m_Game_Interract;
            public InputActionMap Get() { return m_Wrapper.m_Game; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
            public void SetCallbacks(IGameActions instance)
            {
                if (m_Wrapper.m_GameActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                    @Interract.started -= m_Wrapper.m_GameActionsCallbackInterface.OnInterract;
                    @Interract.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnInterract;
                    @Interract.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnInterract;
                }
                m_Wrapper.m_GameActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Interract.started += instance.OnInterract;
                    @Interract.performed += instance.OnInterract;
                    @Interract.canceled += instance.OnInterract;
                }
            }
        }
        public GameActions @Game => new GameActions(this);

        // MainMenu
        private readonly InputActionMap m_MainMenu;
        private IMainMenuActions m_MainMenuActionsCallbackInterface;
        private readonly InputAction m_MainMenu_Join;
        public struct MainMenuActions
        {
            private @MainInputs m_Wrapper;
            public MainMenuActions(@MainInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Join => m_Wrapper.m_MainMenu_Join;
            public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
            public void SetCallbacks(IMainMenuActions instance)
            {
                if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
                {
                    @Join.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnJoin;
                    @Join.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnJoin;
                    @Join.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnJoin;
                }
                m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Join.started += instance.OnJoin;
                    @Join.performed += instance.OnJoin;
                    @Join.canceled += instance.OnJoin;
                }
            }
        }
        public MainMenuActions @MainMenu => new MainMenuActions(this);
        private int m_KeyboardLeftSchemeIndex = -1;
        public InputControlScheme KeyboardLeftScheme
        {
            get
            {
                if (m_KeyboardLeftSchemeIndex == -1) m_KeyboardLeftSchemeIndex = asset.FindControlSchemeIndex("Keyboard Left");
                return asset.controlSchemes[m_KeyboardLeftSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardrightSchemeIndex = -1;
        public InputControlScheme KeyboardrightScheme
        {
            get
            {
                if (m_KeyboardrightSchemeIndex == -1) m_KeyboardrightSchemeIndex = asset.FindControlSchemeIndex("Keyboard right");
                return asset.controlSchemes[m_KeyboardrightSchemeIndex];
            }
        }
        public interface IUIActions
        {
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnMiddleClick(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
        }
        public interface IGameActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnInterract(InputAction.CallbackContext context);
        }
        public interface IMainMenuActions
        {
            void OnJoin(InputAction.CallbackContext context);
        }
    }
}
