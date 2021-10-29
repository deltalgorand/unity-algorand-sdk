# Unity Algorand SDK

> [!Important]
> This package has not been audited and isn't suitable for production use.

This is a demo game showing off some of the basic features for managing assets,
accounts, and transactions using this SDK.

## Install Unity

To get started, install [Unity Hub](https://unity3d.com/get-unity/download) and the latest 2020.3 LTS version.

Clone this project, then open the project directory with Unity. The correct version of the sdk should install
as a package.

## Setup Algod

You'll need a node to connect to the Algorand `testnet`. The easiest way is using
[the Algorand Sandbox](https://github.com/algorand/sandbox).

Once your node is set up and caught up to the latest block, you'll want to double check that
the Algod client has the correct address and token parameters for the node. In the
`Assets/Algorand/Entities` directory, click on the `Algod` asset to see its `Address` and `Token`
settings. Modify them if they need to be changed. This will be the client the game uses to connect to
the algod node.

## Setup an account

In the `Assets/Algorand/Entities` directory, there should be an account called `AssetCreator`. Select this account,
open the context menu, and select `Randomize`. This will generate a random account for you to use. Click the
context menu again, and select `LogAccountInfo`. This will log the account private key, address, and amount of algo to
the console in the editor.

Copy the address that was printed to the editor. Head to
the [testnet Algorand Dispenser](https://bank.testnet.algorand.network/)
and dispense funds to the `AssetCreator` account. Now when you select `LogAccountInfo`, you should see that your
account balance has been updated with Algo.

Repeat the above steps for the `PlayerAccount` asset in `Assets/Algorand/Entities`. Generate a new account, copy the
address, and fund the account.

## Create the smart assets

Click on the `GameCurrency` in `Assets/Algorand/Entities` and open the context menu. Now click on `GetOrCreateAsset`. After a few seconds, the `Index` should be updated to the asset id. You've just created a new smart asset on the testnet.

Repeat for the `SniperRifle` entity in `Assets/Algorand/Entities`.

## Start the game

After creating and funding the `AssetCreator`, `PlayerAccount` accounts, and creating the `GameCurrency`, and `SniperRifle` assets, you are ready to start playing the game.

Double click the scene `Assets/FPS/Scenes/IntroMenu`. Press the **Play** button, and the game should start. In the bottom
left corner you should see your player account's token and algo balance. If you click on the `Weapon Store`, you should
see that there are 100 Sniper Rifles available to purchase. Unfortunately, you do not have enough tokens to purchase the
sniper rifle just yet, so lets earn a token.

## Earn your first token

Press the `PLAY` button in the menu. The `MainScene` should load up. Move your character with `w`, `a`, `s`, and `d` keys, and aim with your mouse. There is an objective in the top left of the screen; complete it to earn a token!

## Buy a sniper rifle

Once completing the objective, a `WinScene` should appear. Go back to the main menu to view the game tokens that we won.
You should have earned 1 game token for completing the objectives. Click on the `Weapon Store` again and press `BUY`
button. After a few seconds, you should see the weapon count decrease in the sniper rifles for sale, but increase in the
sniper rifles you own. You just completed an atomic transfer.

Start the game again. Now you should see a floating sniper rifle when you start the game. Run into the sniper rifle and you should see it pop up into your inventory in the bottom left of the screen. Press the `2` key to activate the sniper rifle.
