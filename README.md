# Time Travel

An example project to demonstrate reconstructing a scene when it loads.

## Instructions

Start with `ThePast` scene. Press `1` to place a blue object. Press `2` to place a red object. Press `f` to jump to `TheFuture` scene.

Notice that every blue cube has changed to a blue sphere, and every red cube has changed to a red sphere.

## How to configure

Configuring the `Builder` script is different for the two scenes:

### ThePast

In `ThePast` scene, you need to configure the `Named Prefabs` list. Each entry needs a name and a prefab. You need to configure an entry for each type of object you can create. In this example you need a `RedObject` and a `BlueObject`. Each entry also needs an associated prefab.

### TheFuture

In `TheFuture` scene, you need to configure the `Named Prefabs` list as above. But instead of associating each item with an object representing the item in the past, you should associate it with an object representing the item in the future.

### Extending this project

If you want to add more types of object to build, you need to remember to add entries to both the `Named Prefabs` list on the `Player` object in `ThePast` and in `TheFuture` scenes.
