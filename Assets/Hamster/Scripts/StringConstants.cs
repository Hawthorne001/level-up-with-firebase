﻿// Copyright 2017 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hamster {

  // String constants used by MechaHamster.
  class StringConstants {
    // External Links
    public const string PrivacyPolicyURL = "https://www.google.com/policies/privacy/";
    public const string TermsAndServicesURL = "https://www.google.com/policies/terms/";

    // Data used for test loops.
    public static readonly string[] TestLoopLevel = {
      "blastingoff",
      "map01",
      "map02",
      "map03",
      "map04",
      "map05",
    };

    public const string TestLoopReplayData = "replays/blast_off_replay_01";

    // Names for Buttons:
    public const string ButtonSave = "Save";
    public const string ButtonLoad = "Load";
    public const string ButtonClear = "Clear";
    public const string ButtonPlay = "Play";
    public const string ButtonMainMenu = "Main Menu";
    public const string ButtonEditor = "Editor";
    public const string ButtonInvite = "Share Map";
    public const string ButtonPlayShared = "Play Shared Map";
    public const string ButtonPlayBonus = "Play Bonus Maps";
    public const string ButtonOkay = "Okay";
    public const string ButtonCancel = "Cancel";
    public const string ButtonMenu = "Menu";
    public const string ButtonAccount = "Account";
    public const string ButtonRetry = "Retry";
    public const string ButtonExit = "Exit";
    public const string ButtonOrientation = "Orientation: ";
    public const string ButtonTopTimes = "Top Times";
    public const string ButtonUploadTime = "Upload Time";
    public const string ButtonReplayPlay = "Show";
    public const string ButtonReplayWait = "Wait...";
    public const string ButtonReplayStop = "Stop";

    // Title screen text:
    public const string TitleText = "MechaHamster!";
    public const string SubTitleText = "The thrilling adventures of Col. Hammy D. Hamster!";
    public const string LabelFetchingUserData = "Fetching User Data";
    public const string CouldNotFetchUserData = "Could not connect to user database.\n" +
        "Some features will be disabled.";

    // Save/Load screen text:
    public const string LabelSaveMap = "Save Map:";
    public const string LabelSaveBonusMap = "Save Bonus Map:";
    public const string LabelLoadMap = "Load Map:";
    public const string ButtonSaveInNew = "Save as New Map";
    public const string ButtonSaveUpdate = "Save Map";
    public const string LabelName = "Name:";
    public const string LabelMapId = "Map Id:";
    public const string LabelOverwrite = "Overwrite an existing map:";

    // Default names:
    public const string DefaultUserName = "Unnamed User";
    public const string DefaultMapName = "Unnamed Map";
    public const string DefaultMapId = "<<default mapid>>";

    // Level finished screen text:
    public const string FinishedTopText = "Great Job!";
    public const string FinishedTimeText = "Time: {0} s";

    // Top Times page:
    public const string TopTimesTitle = "Top Times";
    public const string TopTimesHighlight = "*** {0} ***";

    // Uploading scores page:
    public const string UploadTimeTitle = "Uploading Time";
    public const string UploadPending = "Uploading";
    public const string UploadError = "Failed to upload time";
    // Key used to save names for uploading scores:
    public const string UploadScoreNameKey = "upload_score_name";
    public const string UploadScoreDefaultName = "Hammy";

    // Level selection text
    public const string BuiltinLevelScreenTitle = "Hammy's Adventures";
    public const string SharedLevelScreenTitle = "Shared Maps";
    public const string BonusLevelScreenTitle = "Bonus Maps";

    // Key used for volume settings
    public const string MusicVolume = "music_volume";
    public const string SoundFxVolume = "sound_fx_volume";

    // Key used for sign in state

    // Auth:
    //--------------------------

    public const string LabelCreateAccount = "Create an Account!";
    public const string LabelAddEmail = "Add an Email!";
    public const string LabelLinkingAccount = "Linking account";

    public const string LabelEmail = "Email:";
    public const string LabelPassword = "Password:";
    public const string ButtonCreateAccount = "Create Account!";



    public const string LabelLoading = "Loading";

    public const string LabelAnonymousAccount = "You are signed in on an anonymous account.";
    public const string LabelPasswordAccount = "You are signed in to an email/password account.";

    public const string ButtonAddEmailPassword = "Add Email/Password";
    public const string ButtonLogout = "Log out";
    public const string LabelAnonymousWarning = "You are currently using an anonymous account.\n" +
        "If you log out, you will lose anything you have saved.\n" +
        "Are you sure you want to log out?";




    public const string SharedMapUserMessage = "Someone has shared a new map with you!:\n" +
      "{0}\nFind it under 'Shared Maps'!";

    // Messaging:
    //--------------------------
    // Type of the message being received.
    public const string MessageKeyType = "type";

    // Bonus Map message.
    // Received when a new bonus map is granted.
    // Params:
    // MessageDataMapId, MessageDataMapName
    public const string MessageTypeBonusMap = "bonus_map";

    // A map id being sent.  Usually for a new bonus level.
    public const string MessageDataMapId = "map_id";

    // The plaintext name of the map being sent.  Usually for a new bonus level.
    public const string MessageDataMapName = "map_name";

    public const string BonusMapUserMessage = "You received the bonus map:\n" +
      "{0}\n Play it from the main menu!";

    // Text message.
    // Sends the user a text message.
    // Params:
    // MessageDataText
    public const string MessageTypeText = "text_message";

    // The plaintext name of the map being sent.  Usually for a new bonus level.
    public const string MessageDataText = "text";

    // Animation Parameters:
    //--------------------------
    // Triggers the spring/jump tile animation.
    public const string AnimationSpring = "spring";
    public const string AnimationSpringIdleState = "Idle";
    // Triggers the launching of the mine.
    public const string AnimationLaunchMine = "launch_mine";
    public const string AnimationMineIdleState = "Idle";
    // Toggles the switch animation to go up and down (false is up).
    public const string AnimationSwitch = "switch";
    public const string AnimationSwitchIdleState = "ButtonStart";
    // Triggers the spikes going up and down.
    public const string AnimationSpikesDown = "spikes_down";
    public const string AnimationSpikesUp = "spikes_up";
    // The state of the spikes idling in the down/up positions.
    public const string AnimationSpikesIdleDown = "IdleDown";
    public const string AnimationSpikesIdleUp = "IdleUp";
    // The trigger and idle state for the breakable tile.
    public const string AnimationBreakTile = "break";
    public const string AnimationBreakIdleState = "Idle";

    // Deleting accounts:
    //--------------------------
    public const string DeleteAccountMessage = "Deleting Account";
    public const string DeleteAccountFail = "Account deletion failed.";
    public const string DeleteAccountSuccess = "Account has been deleted.";
    public const string DeleteAccountDialogTitle = "Delete Account?";
    public const string DeleteAccountDialogMessage =
        "This will delete your account, and all saved maps.  Are you sure?";

    // Menu identifiers:
    //--------------------------
    public const string PrefabMainMenu = "MainMenu";
    public const string PrefabBasicDialog = "BasicDialog";
    public const string PrefabLicenseDialog = "LicenseDialog";
    public const string PrefabsLevelSelectMenu = "LevelSelectMenu";
    public const string PrefabsLevelSelectButton = "LevelSelectButton";
    public const string PrefabsLevelFinishedMenu = "LevelFinishedMenu";
    public const string PrefabsControllerHelp = "ControllerHelp";
    public const string PrefabsTopTimes = "TopTimes";
    public const string PrefabsSettingsMenu = "SettingsMenu";
    public const string PrefabsPasswordResetMenu = "PasswordResetMenu";
    public const string PrefabsAddEmailMenu = "AddEmailMenu";
    public const string PrefabsNewAccountMenu = "NewAccountMenu";
    public const string PrefabsManageAccountMenu = "ManageAccountMenu";
    public const string PrefabsSingleLabelMenu = "SingleLabelMenu";
    public const string PrefabEditorMenu = "EditorMenu";
    public const string PrefabEditorToolButton = "EditorToolButton";
    public const string PrefabSaveMapMenu = "SaveMapMenu";
    public const string PrefabConfirmationDialog = "ConfirmationDialog";
    public const string PrefabSelfDestructMenu = "SelfDestructMenu";
    public const string PrefabMeltdownMenu = "MeltdownMenu";
  }
}
