namespace X11
{
  public enum Key
  {
    VoidSymbol = 16777215,
    BackSpace = 65288,
    Tab,
    Linefeed,
    Clear,
    Return = 65293,
    Pause = 65299,
    Scroll_Lock,
    Sys_Req,
    Escape = 65307,
    Delete = 65535,
    Multi_key = 65312,
    Codeinput = 65335,
    SingleCandidate = 65340,
    MultipleCandidate,
    PreviousCandidate,
    Kanji = 65313,
    Muhenkan,
    Henkan_Mode,
    Henkan = 65315,
    Romaji,
    Hiragana,
    Katakana,
    Hiragana_Katakana,
    Zenkaku,
    Hankaku,
    Zenkaku_Hankaku,
    Touroku,
    Massyo,
    Kana_Lock,
    Kana_Shift,
    Eisu_Shift,
    Eisu_toggle,
    Kanji_Bangou = 65335,
    Zen_Koho = 65341,
    Mae_Koho,
    Home = 65360,
    Left,
    Up,
    Right,
    Down,
    Prior,
    Page_Up = 65365,
    Next,
    Page_Down = 65366,
    End,
    Begin,
    Select = 65376,
    Print,
    Execute,
    Insert,
    Undo = 65381,
    Redo,
    Menu,
    Find,
    Cancel,
    Help,
    Break,
    Mode_switch = 65406,
    script_switch = 65406,
    Num_Lock,
    KP_Space,
    KP_Tab = 65417,
    KP_Enter = 65421,
    KP_F1 = 65425,
    KP_F2,
    KP_F3,
    KP_F4,
    KP_Home,
    KP_Left,
    KP_Up,
    KP_Right,
    KP_Down,
    KP_Prior,
    KP_Page_Up = 65434,
    KP_Next,
    KP_Page_Down = 65435,
    KP_End,
    KP_Begin,
    KP_Insert,
    KP_Delete,
    KP_Equal = 65469,
    KP_Multiply = 65450,
    KP_Add,
    KP_Separator,
    KP_Subtract,
    KP_Decimal,
    KP_Divide,
    KP_0,
    KP_1,
    KP_2,
    KP_3,
    KP_4,
    KP_5,
    KP_6,
    KP_7,
    KP_8,
    KP_9,
    F1 = 65470,
    F2,
    F3,
    F4,
    F5,
    F6,
    F7,
    F8,
    F9,
    F10,
    F11,
    L1 = 65480,
    F12,
    L2 = 65481,
    F13,
    L3 = 65482,
    F14,
    L4 = 65483,
    F15,
    L5 = 65484,
    F16,
    L6 = 65485,
    F17,
    L7 = 65486,
    F18,
    L8 = 65487,
    F19,
    L9 = 65488,
    F20,
    L10 = 65489,
    F21,
    R1 = 65490,
    F22,
    R2 = 65491,
    F23,
    R3 = 65492,
    F24,
    R4 = 65493,
    F25,
    R5 = 65494,
    F26,
    R6 = 65495,
    F27,
    R7 = 65496,
    F28,
    R8 = 65497,
    F29,
    R9 = 65498,
    F30,
    R10 = 65499,
    F31,
    R11 = 65500,
    F32,
    R12 = 65501,
    F33,
    R13 = 65502,
    F34,
    R14 = 65503,
    F35,
    R15 = 65504,
    Shift_L,
    Shift_R,
    Control_L,
    Control_R,
    Caps_Lock,
    Shift_Lock,
    Meta_L,
    Meta_R,
    Alt_L,
    Alt_R,
    Super_L,
    Super_R,
    Hyper_L,
    Hyper_R,
    ISO_Lock = 65025,
    ISO_Level2_Latch,
    ISO_Level3_Shift,
    ISO_Level3_Latch,
    ISO_Level3_Lock,
    ISO_Group_Shift = 65406,
    ISO_Group_Latch = 65030,
    ISO_Group_Lock,
    ISO_Next_Group,
    ISO_Next_Group_Lock,
    ISO_Prev_Group,
    ISO_Prev_Group_Lock,
    ISO_First_Group,
    ISO_First_Group_Lock,
    ISO_Last_Group,
    ISO_Last_Group_Lock,
    ISO_Left_Tab = 65056,
    ISO_Move_Line_Up,
    ISO_Move_Line_Down,
    ISO_Partial_Line_Up,
    ISO_Partial_Line_Down,
    ISO_Partial_Space_Left,
    ISO_Partial_Space_Right,
    ISO_Set_Margin_Left,
    ISO_Set_Margin_Right,
    ISO_Release_Margin_Left,
    ISO_Release_Margin_Right,
    ISO_Release_Both_Margins,
    ISO_Fast_Cursor_Left,
    ISO_Fast_Cursor_Right,
    ISO_Fast_Cursor_Up,
    ISO_Fast_Cursor_Down,
    ISO_Continuous_Underline,
    ISO_Discontinuous_Underline,
    ISO_Emphasize,
    ISO_Center_Object,
    ISO_Enter,
    dead_grave = 65104,
    dead_acute,
    dead_circumflex,
    dead_tilde,
    dead_macron,
    dead_breve,
    dead_abovedot,
    dead_diaeresis,
    dead_abovering,
    dead_doubleacute,
    dead_caron,
    dead_cedilla,
    dead_ogonek,
    dead_iota,
    dead_voiced_sound,
    dead_semivoiced_sound,
    dead_belowdot,
    First_Virtual_Screen = 65232,
    Prev_Virtual_Screen,
    Next_Virtual_Screen,
    Last_Virtual_Screen = 65236,
    Terminate_Server,
    AccessX_Enable = 65136,
    AccessX_Feedback_Enable,
    RepeatKeys_Enable,
    SlowKeys_Enable,
    BounceKeys_Enable,
    StickyKeys_Enable,
    MouseKeys_Enable,
    MouseKeys_Accel_Enable,
    Overlay1_Enable,
    Overlay2_Enable,
    AudibleBell_Enable,
    Pointer_Left = 65248,
    Pointer_Right,
    Pointer_Up,
    Pointer_Down,
    Pointer_UpLeft,
    Pointer_UpRight,
    Pointer_DownLeft,
    Pointer_DownRight,
    Pointer_Button_Dflt,
    Pointer_Button1,
    Pointer_Button2,
    Pointer_Button3,
    Pointer_Button4,
    Pointer_Button5,
    Pointer_DblClick_Dflt,
    Pointer_DblClick1,
    Pointer_DblClick2,
    Pointer_DblClick3,
    Pointer_DblClick4,
    Pointer_DblClick5,
    Pointer_Drag_Dflt,
    Pointer_Drag1,
    Pointer_Drag2,
    Pointer_Drag3,
    Pointer_Drag4,
    Pointer_Drag5 = 65277,
    Pointer_EnableKeys = 65273,
    Pointer_Accelerate,
    Pointer_DfltBtnNext,
    Pointer_DfltBtnPrev,
    Key_3270_Duplicate = 64769,
    Key_3270_FieldMark,
    Key_3270_Right2,
    Key_3270_Left2,
    Key_3270_BackTab,
    Key_3270_EraseEOF,
    Key_3270_EraseInput,
    Key_3270_Reset,
    Key_3270_Quit,
    Key_3270_PA1,
    Key_3270_PA2,
    Key_3270_PA3,
    Key_3270_Test,
    Key_3270_Attn,
    Key_3270_CursorBlink,
    Key_3270_AltCursor,
    Key_3270_KeyClick,
    Key_3270_Jump,
    Key_3270_Ident,
    Key_3270_Rule,
    Key_3270_Copy,
    Key_3270_Play,
    Key_3270_Setup,
    Key_3270_Record,
    Key_3270_ChangeScreen,
    Key_3270_DeleteWord,
    Key_3270_ExSelect,
    Key_3270_CursorSelect,
    Key_3270_PrintScreen,
    Key_3270_Enter,
    space = 32,
    exclam,
    quotedbl,
    numbersign,
    dollar,
    percent,
    ampersand,
    apostrophe,
    quoteright = 39,
    parenleft,
    parenright,
    asterisk,
    plus,
    comma,
    minus,
    period,
    slash,
    Key_0,
    Key_1,
    Key_2,
    Key_3,
    Key_4,
    Key_5,
    Key_6,
    Key_7,
    Key_8,
    Key_9,
    colon,
    semicolon,
    less,
    equal,
    greater,
    question,
    at,
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
    J,
    K,
    L,
    M,
    N,
    O,
    P,
    Q,
    R,
    S,
    T,
    U,
    V,
    W,
    X,
    Y,
    Z,
    bracketleft,
    backslash,
    bracketright,
    asciicircum,
    underscore,
    grave,
    quoteleft = 96,
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
    j,
    k,
    l,
    m,
    n,
    o,
    p,
    q,
    r,
    s,
    t,
    u,
    v,
    w,
    x,
    y,
    z,
    braceleft,
    bar,
    braceright,
    asciitilde,
    nobreakspace = 160,
    exclamdown,
    cent,
    sterling,
    currency,
    yen,
    brokenbar,
    section,
    diaeresis,
    copyright,
    ordfeminine,
    guillemotleft,
    notsign,
    hyphen,
    registered,
    macron,
    degree,
    plusminus,
    twosuperior,
    threesuperior,
    acute,
    mu,
    paragraph,
    periodcentered,
    cedilla,
    onesuperior,
    masculine,
    guillemotright,
    onequarter,
    onehalf,
    threequarters,
    questiondown,
    Agrave,
    Aacute,
    Acircumflex,
    Atilde,
    Adiaeresis,
    Aring,
    AE,
    Ccedilla,
    Egrave,
    Eacute,
    Ecircumflex,
    Ediaeresis,
    Igrave,
    Iacute,
    Icircumflex,
    Idiaeresis,
    ETH,
    Eth = 208,
    Ntilde,
    Ograve,
    Oacute,
    Ocircumflex,
    Otilde,
    Odiaeresis,
    multiply,
    Ooblique,
    Ugrave,
    Uacute,
    Ucircumflex,
    Udiaeresis,
    Yacute,
    THORN,
    Thorn = 222,
    ssharp,
    agrave,
    aacute,
    acircumflex,
    atilde,
    adiaeresis,
    aring,
    ae,
    ccedilla,
    egrave,
    eacute,
    ecircumflex,
    ediaeresis,
    igrave,
    iacute,
    icircumflex,
    idiaeresis,
    eth,
    ntilde,
    ograve,
    oacute,
    ocircumflex,
    otilde,
    odiaeresis,
    division,
    oslash,
    ugrave,
    uacute,
    ucircumflex,
    udiaeresis,
    yacute,
    thorn,
    ydiaeresis,
    Aogonek = 417,
    breve,
    Lstroke,
    Lcaron = 421,
    Sacute,
    Scaron = 425,
    Scedilla,
    Tcaron,
    Zacute,
    Zcaron = 430,
    Zabovedot,
    aogonek = 433,
    ogonek,
    lstroke,
    lcaron = 437,
    sacute,
    caron,
    scaron = 441,
    scedilla,
    tcaron,
    zacute,
    doubleacute,
    zcaron,
    zabovedot,
    Racute,
    Abreve = 451,
    Lacute = 453,
    Cacute,
    Ccaron = 456,
    Eogonek = 458,
    Ecaron = 460,
    Dcaron = 463,
    Dstroke,
    Nacute,
    Ncaron,
    Odoubleacute = 469,
    Rcaron = 472,
    Uring,
    Udoubleacute = 475,
    Tcedilla = 478,
    racute = 480,
    abreve = 483,
    lacute = 485,
    cacute,
    ccaron = 488,
    eogonek = 490,
    ecaron = 492,
    dcaron = 495,
    dstroke,
    nacute,
    ncaron,
    odoubleacute = 501,
    udoubleacute = 507,
    rcaron = 504,
    uring,
    tcedilla = 510,
    abovedot,
    Hstroke = 673,
    Hcircumflex = 678,
    Iabovedot = 681,
    Gbreve = 683,
    Jcircumflex,
    hstroke = 689,
    hcircumflex = 694,
    idotless = 697,
    gbreve = 699,
    jcircumflex,
    Cabovedot = 709,
    Ccircumflex,
    Gabovedot = 725,
    Gcircumflex = 728,
    Ubreve = 733,
    Scircumflex,
    cabovedot = 741,
    ccircumflex,
    gabovedot = 757,
    gcircumflex = 760,
    ubreve = 765,
    scircumflex,
    kra = 930,
    kappa = 930,
    Rcedilla,
    Itilde = 933,
    Lcedilla,
    Emacron = 938,
    Gcedilla,
    Tslash,
    rcedilla = 947,
    itilde = 949,
    lcedilla,
    emacron = 954,
    gcedilla,
    tslash,
    ENG,
    eng = 959,
    Amacron,
    Iogonek = 967,
    Eabovedot = 972,
    Imacron = 975,
    Ncedilla = 977,
    Omacron,
    Kcedilla,
    Uogonek = 985,
    Utilde = 989,
    Umacron,
    amacron = 992,
    iogonek = 999,
    eabovedot = 1004,
    imacron = 1007,
    ncedilla = 1009,
    omacron,
    kcedilla,
    uogonek = 1017,
    utilde = 1021,
    umacron,
    OE = 5052,
    oe,
    Ydiaeresis,
    overline = 1150,
    kana_fullstop = 1185,
    kana_openingbracket,
    kana_closingbracket,
    kana_comma,
    kana_conjunctive,
    kana_middledot = 1189,
    kana_WO,
    kana_a,
    kana_i,
    kana_u,
    kana_e,
    kana_o,
    kana_ya,
    kana_yu,
    kana_yo,
    kana_tsu,
    kana_tu = 1199,
    prolongedsound,
    kana_A,
    kana_I,
    kana_U,
    kana_E,
    kana_O,
    kana_KA,
    kana_KI,
    kana_KU,
    kana_KE,
    kana_KO,
    kana_SA,
    kana_SHI,
    kana_SU,
    kana_SE,
    kana_SO,
    kana_TA,
    kana_CHI,
    kana_TI = 1217,
    kana_TSU,
    kana_TU = 1218,
    kana_TE,
    kana_TO,
    kana_NA,
    kana_NI,
    kana_NU,
    kana_NE,
    kana_NO,
    kana_HA,
    kana_HI,
    kana_FU,
    kana_HU = 1228,
    kana_HE,
    kana_HO,
    kana_MA,
    kana_MI,
    kana_MU,
    kana_ME,
    kana_MO,
    kana_YA,
    kana_YU,
    kana_YO,
    kana_RA,
    kana_RI,
    kana_RU,
    kana_RE,
    kana_RO,
    kana_WA,
    kana_N,
    voicedsound,
    semivoicedsound,
    kana_switch = 65406,
    Arabic_comma = 1452,
    Arabic_semicolon = 1467,
    Arabic_question_mark = 1471,
    Arabic_hamza = 1473,
    Arabic_maddaonalef,
    Arabic_hamzaonalef,
    Arabic_hamzaonwaw,
    Arabic_hamzaunderalef,
    Arabic_hamzaonyeh,
    Arabic_alef,
    Arabic_beh,
    Arabic_tehmarbuta,
    Arabic_teh,
    Arabic_theh,
    Arabic_jeem,
    Arabic_hah,
    Arabic_khah,
    Arabic_dal,
    Arabic_thal,
    Arabic_ra,
    Arabic_zain,
    Arabic_seen,
    Arabic_sheen,
    Arabic_sad,
    Arabic_dad,
    Arabic_tah,
    Arabic_zah,
    Arabic_ain,
    Arabic_ghain,
    Arabic_tatweel = 1504,
    Arabic_feh,
    Arabic_qaf,
    Arabic_kaf,
    Arabic_lam,
    Arabic_meem,
    Arabic_noon,
    Arabic_ha,
    Arabic_heh = 1511,
    Arabic_waw,
    Arabic_alefmaksura,
    Arabic_yeh,
    Arabic_fathatan,
    Arabic_dammatan,
    Arabic_kasratan,
    Arabic_fatha,
    Arabic_damma,
    Arabic_kasra,
    Arabic_shadda,
    Arabic_sukun,
    Arabic_switch = 65406,
    Serbian_dje = 1697,
    Macedonia_gje,
    Cyrillic_io,
    Ukrainian_ie,
    Ukranian_je = 1700,
    Macedonia_dse,
    Ukrainian_i,
    Ukranian_i = 1702,
    Ukrainian_yi,
    Ukranian_yi = 1703,
    Cyrillic_je,
    Serbian_je = 1704,
    Cyrillic_lje,
    Serbian_lje = 1705,
    Cyrillic_nje,
    Serbian_nje = 1706,
    Serbian_tshe,
    Macedonia_kje,
    Byelorussian_shortu = 1710,
    Cyrillic_dzhe,
    Serbian_dze = 1711,
    numerosign,
    Serbian_DJE,
    Macedonia_GJE,
    Cyrillic_IO,
    Ukrainian_IE,
    Ukranian_JE = 1716,
    Macedonia_DSE,
    Ukrainian_I,
    Ukranian_I = 1718,
    Ukrainian_YI,
    Ukranian_YI = 1719,
    Cyrillic_JE,
    Serbian_JE = 1720,
    Cyrillic_LJE,
    Serbian_LJE = 1721,
    Cyrillic_NJE,
    Serbian_NJE = 1722,
    Serbian_TSHE,
    Macedonia_KJE,
    Byelorussian_SHORTU = 1726,
    Cyrillic_DZHE,
    Serbian_DZE = 1727,
    Cyrillic_yu,
    Cyrillic_a,
    Cyrillic_be,
    Cyrillic_tse,
    Cyrillic_de,
    Cyrillic_ie,
    Cyrillic_ef,
    Cyrillic_ghe,
    Cyrillic_ha,
    Cyrillic_i,
    Cyrillic_shorti,
    Cyrillic_ka,
    Cyrillic_el,
    Cyrillic_em,
    Cyrillic_en,
    Cyrillic_o,
    Cyrillic_pe,
    Cyrillic_ya,
    Cyrillic_er,
    Cyrillic_es,
    Cyrillic_te,
    Cyrillic_u,
    Cyrillic_zhe,
    Cyrillic_ve,
    Cyrillic_softsign,
    Cyrillic_yeru,
    Cyrillic_ze,
    Cyrillic_sha,
    Cyrillic_e,
    Cyrillic_shcha,
    Cyrillic_che,
    Cyrillic_hardsign,
    Cyrillic_YU,
    Cyrillic_A,
    Cyrillic_BE,
    Cyrillic_TSE,
    Cyrillic_DE,
    Cyrillic_IE,
    Cyrillic_EF,
    Cyrillic_GHE,
    Cyrillic_HA,
    Cyrillic_I,
    Cyrillic_SHORTI,
    Cyrillic_KA,
    Cyrillic_EL,
    Cyrillic_EM,
    Cyrillic_EN,
    Cyrillic_O,
    Cyrillic_PE,
    Cyrillic_YA,
    Cyrillic_ER,
    Cyrillic_ES,
    Cyrillic_TE,
    Cyrillic_U,
    Cyrillic_ZHE,
    Cyrillic_VE,
    Cyrillic_SOFTSIGN,
    Cyrillic_YERU,
    Cyrillic_ZE,
    Cyrillic_SHA,
    Cyrillic_E,
    Cyrillic_SHCHA,
    Cyrillic_CHE,
    Cyrillic_HARDSIGN,
    Greek_ALPHAaccent = 1953,
    Greek_EPSILONaccent,
    Greek_ETAaccent,
    Greek_IOTAaccent,
    Greek_IOTAdiaeresis,
    Greek_OMICRONaccent = 1959,
    Greek_UPSILONaccent,
    Greek_UPSILONdieresis,
    Greek_OMEGAaccent = 1963,
    Greek_accentdieresis = 1966,
    Greek_horizbar,
    Greek_alphaaccent = 1969,
    Greek_epsilonaccent,
    Greek_etaaccent,
    Greek_iotaaccent,
    Greek_iotadieresis,
    Greek_iotaaccentdieresis,
    Greek_omicronaccent,
    Greek_upsilonaccent,
    Greek_upsilondieresis,
    Greek_upsilonaccentdieresis,
    Greek_omegaaccent,
    Greek_ALPHA = 1985,
    Greek_BETA,
    Greek_GAMMA,
    Greek_DELTA,
    Greek_EPSILON,
    Greek_ZETA,
    Greek_ETA,
    Greek_THETA,
    Greek_IOTA,
    Greek_KAPPA,
    Greek_LAMDA,
    Greek_LAMBDA = 1995,
    Greek_MU,
    Greek_NU,
    Greek_XI,
    Greek_OMICRON,
    Greek_PI,
    Greek_RHO,
    Greek_SIGMA,
    Greek_TAU = 2004,
    Greek_UPSILON,
    Greek_PHI,
    Greek_CHI,
    Greek_PSI,
    Greek_OMEGA,
    Greek_alpha = 2017,
    Greek_beta,
    Greek_gamma,
    Greek_delta,
    Greek_epsilon,
    Greek_zeta,
    Greek_eta,
    Greek_theta,
    Greek_iota,
    Greek_kappa,
    Greek_lamda,
    Greek_lambda = 2027,
    Greek_mu,
    Greek_nu,
    Greek_xi,
    Greek_omicron,
    Greek_pi,
    Greek_rho,
    Greek_sigma,
    Greek_finalsmallsigma,
    Greek_tau,
    Greek_upsilon,
    Greek_phi,
    Greek_chi,
    Greek_psi,
    Greek_omega,
    Greek_switch = 65406,
    leftradical = 2209,
    topleftradical,
    horizconnector,
    topintegral,
    botintegral,
    vertconnector,
    topleftsqbracket,
    botleftsqbracket,
    toprightsqbracket,
    botrightsqbracket,
    topleftparens,
    botleftparens,
    toprightparens,
    botrightparens,
    leftmiddlecurlybrace,
    rightmiddlecurlybrace,
    topleftsummation,
    botleftsummation,
    topvertsummationconnector,
    botvertsummationconnector,
    toprightsummation,
    botrightsummation,
    rightmiddlesummation,
    lessthanequal = 2236,
    notequal,
    greaterthanequal,
    integral,
    therefore,
    variation,
    infinity,
    nabla = 2245,
    approximate = 2248,
    similarequal,
    ifonlyif = 2253,
    implies,
    identical,
    radical = 2262,
    includedin = 2266,
    includes,
    intersection,
    union,
    logicaland,
    logicalor,
    partialderivative = 2287,
    function = 2294,
    leftarrow = 2299,
    uparrow,
    rightarrow,
    downarrow,
    blank = 2527,
    soliddiamond,
    checkerboard,
    ht,
    ff,
    cr,
    lf,
    nl = 2536,
    vt,
    lowrightcorner,
    uprightcorner,
    upleftcorner,
    lowleftcorner,
    crossinglines,
    horizlinescan1,
    horizlinescan3,
    horizlinescan5,
    horizlinescan7,
    horizlinescan9,
    leftt,
    rightt,
    bott,
    topt,
    vertbar,
    emspace = 2721,
    enspace,
    em3space,
    em4space,
    digitspace,
    punctspace,
    thinspace,
    hairspace,
    emdash,
    endash,
    signifblank = 2732,
    ellipsis = 2734,
    doubbaselinedot,
    onethird,
    twothirds,
    onefifth,
    twofifths,
    threefifths,
    fourfifths,
    onesixth,
    fivesixths,
    careof,
    figdash = 2747,
    leftanglebracket,
    decimalpoint,
    rightanglebracket,
    marker,
    oneeighth = 2755,
    threeeighths,
    fiveeighths,
    seveneighths,
    trademark = 2761,
    signaturemark,
    trademarkincircle,
    leftopentriangle,
    rightopentriangle,
    emopencircle,
    emopenrectangle,
    leftsinglequotemark,
    rightsinglequotemark,
    leftdoublequotemark,
    rightdoublequotemark,
    prescription,
    minutes = 2774,
    seconds,
    latincross = 2777,
    hexagram,
    filledrectbullet,
    filledlefttribullet,
    filledrighttribullet,
    emfilledcircle,
    emfilledrect,
    enopencircbullet,
    enopensquarebullet,
    openrectbullet,
    opentribulletup,
    opentribulletdown,
    openstar,
    enfilledcircbullet,
    enfilledsqbullet,
    filledtribulletup,
    filledtribulletdown,
    leftpointer,
    rightpointer,
    club,
    diamond,
    heart,
    maltesecross = 2800,
    dagger,
    doubledagger,
    checkmark,
    ballotcross,
    musicalsharp,
    musicalflat,
    malesymbol,
    femalesymbol,
    telephone,
    telephonerecorder,
    phonographcopyright,
    caret,
    singlelowquotemark,
    doublelowquotemark,
    cursor,
    leftcaret = 2979,
    rightcaret = 2982,
    downcaret = 2984,
    upcaret,
    overbar = 3008,
    downtack = 3010,
    upshoe,
    downstile,
    underbar = 3014,
    jot = 3018,
    quad = 3020,
    uptack = 3022,
    circle,
    upstile = 3027,
    downshoe = 3030,
    rightshoe = 3032,
    leftshoe = 3034,
    lefttack = 3036,
    righttack = 3068,
    hebrew_doublelowline = 3295,
    hebrew_aleph,
    hebrew_bet,
    hebrew_beth = 3297,
    hebrew_gimel,
    hebrew_gimmel = 3298,
    hebrew_dalet,
    hebrew_daleth = 3299,
    hebrew_he,
    hebrew_waw,
    hebrew_zain,
    hebrew_zayin = 3302,
    hebrew_chet,
    hebrew_het = 3303,
    hebrew_tet,
    hebrew_teth = 3304,
    hebrew_yod,
    hebrew_finalkaph,
    hebrew_kaph,
    hebrew_lamed,
    hebrew_finalmem,
    hebrew_mem,
    hebrew_finalnun,
    hebrew_nun,
    hebrew_samech,
    hebrew_samekh = 3313,
    hebrew_ayin,
    hebrew_finalpe,
    hebrew_pe,
    hebrew_finalzade,
    hebrew_finalzadi = 3317,
    hebrew_zade,
    hebrew_zadi = 3318,
    hebrew_qoph,
    hebrew_kuf = 3319,
    hebrew_resh,
    hebrew_shin,
    hebrew_taw,
    hebrew_taf = 3322,
    Hebrew_switch = 65406,
    Thai_kokai = 3489,
    Thai_khokhai,
    Thai_khokhuat,
    Thai_khokhwai,
    Thai_khokhon,
    Thai_khorakhang,
    Thai_ngongu,
    Thai_chochan,
    Thai_choching,
    Thai_chochang,
    Thai_soso,
    Thai_chochoe,
    Thai_yoying,
    Thai_dochada,
    Thai_topatak,
    Thai_thothan,
    Thai_thonangmontho,
    Thai_thophuthao,
    Thai_nonen,
    Thai_dodek,
    Thai_totao,
    Thai_thothung,
    Thai_thothahan,
    Thai_thothong,
    Thai_nonu,
    Thai_bobaimai,
    Thai_popla,
    Thai_phophung,
    Thai_fofa,
    Thai_phophan,
    Thai_fofan,
    Thai_phosamphao,
    Thai_moma,
    Thai_yoyak,
    Thai_rorua,
    Thai_ru,
    Thai_loling,
    Thai_lu,
    Thai_wowaen,
    Thai_sosala,
    Thai_sorusi,
    Thai_sosua,
    Thai_hohip,
    Thai_lochula,
    Thai_oang,
    Thai_honokhuk,
    Thai_paiyannoi,
    Thai_saraa,
    Thai_maihanakat,
    Thai_saraaa,
    Thai_saraam,
    Thai_sarai,
    Thai_saraii,
    Thai_saraue,
    Thai_sarauee,
    Thai_sarau,
    Thai_sarauu,
    Thai_phinthu,
    Thai_maihanakat_maitho = 3550,
    Thai_baht,
    Thai_sarae,
    Thai_saraae,
    Thai_sarao,
    Thai_saraaimaimuan,
    Thai_saraaimaimalai,
    Thai_lakkhangyao,
    Thai_maiyamok,
    Thai_maitaikhu,
    Thai_maiek,
    Thai_maitho,
    Thai_maitri,
    Thai_maichattawa,
    Thai_thanthakhat,
    Thai_nikhahit,
    Thai_leksun = 3568,
    Thai_leknung,
    Thai_leksong,
    Thai_leksam,
    Thai_leksi,
    Thai_lekha,
    Thai_lekhok,
    Thai_lekchet,
    Thai_lekpaet,
    Thai_lekkao,
    Hangul = 65329,
    Hangul_Start,
    Hangul_End,
    Hangul_Hanja,
    Hangul_Jamo,
    Hangul_Romaja,
    Hangul_Codeinput,
    Hangul_Jeonja,
    Hangul_Banja,
    Hangul_PreHanja,
    Hangul_PostHanja,
    Hangul_SingleCandidate,
    Hangul_MultipleCandidate,
    Hangul_PreviousCandidate,
    Hangul_Special,
    Hangul_switch = 65406,
    Hangul_Kiyeog = 3745,
    Hangul_SsangKiyeog,
    Hangul_KiyeogSios,
    Hangul_Nieun,
    Hangul_NieunJieuj,
    Hangul_NieunHieuh,
    Hangul_Dikeud,
    Hangul_SsangDikeud,
    Hangul_Rieul,
    Hangul_RieulKiyeog,
    Hangul_RieulMieum,
    Hangul_RieulPieub,
    Hangul_RieulSios,
    Hangul_RieulTieut,
    Hangul_RieulPhieuf,
    Hangul_RieulHieuh,
    Hangul_Mieum,
    Hangul_Pieub,
    Hangul_SsangPieub,
    Hangul_PieubSios,
    Hangul_Sios,
    Hangul_SsangSios,
    Hangul_Ieung,
    Hangul_Jieuj,
    Hangul_SsangJieuj,
    Hangul_Cieuc,
    Hangul_Khieuq,
    Hangul_Tieut,
    Hangul_Phieuf,
    Hangul_Hieuh,
    Hangul_A,
    Hangul_AE,
    Hangul_YA,
    Hangul_YAE,
    Hangul_EO,
    Hangul_E,
    Hangul_YEO,
    Hangul_YE,
    Hangul_O,
    Hangul_WA,
    Hangul_WAE,
    Hangul_OE,
    Hangul_YO,
    Hangul_U,
    Hangul_WEO,
    Hangul_WE,
    Hangul_WI,
    Hangul_YU,
    Hangul_EU,
    Hangul_YI,
    Hangul_I,
    Hangul_J_Kiyeog,
    Hangul_J_SsangKiyeog,
    Hangul_J_KiyeogSios,
    Hangul_J_Nieun,
    Hangul_J_NieunJieuj,
    Hangul_J_NieunHieuh,
    Hangul_J_Dikeud,
    Hangul_J_Rieul,
    Hangul_J_RieulKiyeog,
    Hangul_J_RieulMieum,
    Hangul_J_RieulPieub,
    Hangul_J_RieulSios,
    Hangul_J_RieulTieut,
    Hangul_J_RieulPhieuf,
    Hangul_J_RieulHieuh,
    Hangul_J_Mieum,
    Hangul_J_Pieub,
    Hangul_J_PieubSios,
    Hangul_J_Sios,
    Hangul_J_SsangSios,
    Hangul_J_Ieung,
    Hangul_J_Jieuj,
    Hangul_J_Cieuc,
    Hangul_J_Khieuq,
    Hangul_J_Tieut,
    Hangul_J_Phieuf,
    Hangul_J_Hieuh,
    Hangul_RieulYeorinHieuh,
    Hangul_SunkyeongeumMieum,
    Hangul_SunkyeongeumPieub,
    Hangul_PanSios,
    Hangul_KkogjiDalrinIeung,
    Hangul_SunkyeongeumPhieuf,
    Hangul_YeorinHieuh,
    Hangul_AraeA,
    Hangul_AraeAE,
    Hangul_J_PanSios,
    Hangul_J_KkogjiDalrinIeung,
    Hangul_J_YeorinHieuh,
    Korean_Won = 3839,
    EcuSign = 8352,
    ColonSign,
    CruzeiroSign,
    FFrancSign,
    LiraSign,
    MillSign,
    NairaSign,
    PesetaSign,
    RupeeSign,
    WonSign,
    NewSheqelSign,
    DongSign,
    EuroSign
  }
}