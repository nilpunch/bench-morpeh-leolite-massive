https://telegra.ph/Benchi-navskidku-Morpeh-vs-LeoLite-04-17

## Environment

![image](https://github.com/user-attachments/assets/6e9d60d5-819e-4557-8d31-4ddc83fed7fd)

## Build

Standard use cases without case-specific optimizations; IL2CPP Master build.

## Results

| Test                                         | morpeh  | leolite | massive (filter) | massive (filter, stable) | massive (group) |
| -------------------------------------------- | ------- | ------- | ---------------- | ------------------------ | --------------- |
| Modify 4 components in 500K entities         | 3.7ms   | 3.4ms   | 4.2ms            | 4.2 ms                   | 4.3 ms          |
| Remove and add 1 component in 100K entities  | 7.3ms   | 13ms    | 1.9ms            | 1.5 ms                   | 8.1 ms          |
| Remove and add 3 components in 100K entities | 10.2ms  | 28.5ms  | 4.1ms            | 2.2 ms                   | 14.2 ms         |
