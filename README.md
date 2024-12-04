https://telegra.ph/Benchi-navskidku-Morpeh-vs-LeoLite-04-17

## Environment

![image](https://github.com/user-attachments/assets/6e9d60d5-819e-4557-8d31-4ddc83fed7fd)

## Build

Standard use cases without case-specific optimizations; IL2CPP Release build.

## Results

| Test                                         | morpeh (2024.1.0)  | leolite (2023.11.22) | massive (17.0.0) | massive (groups) |
| -------------------------------------------- | ------------------ | -------------------- | ---------------- | ---------------- |
| Modify 4 components in 500K entities         | 3.7ms              | 3.9ms                | 4.8ms            | 3.7ms            |
| Remove and add 1 component in 500K entities  | 42.2ms             | 67.8ms               | 6.3ms            | 19.6ms           |
| Remove and add 3 components in 500K entities | 51.2ms             | 147.4ms              | 15.4ms           | 31.9ms           |

## Memory consumption with 4 components, 4 filters, and 500K entities

| Project              | ram (mono) |
| -------------------- | ---------- |
| morpeh (2024.1.0)    | 163mb      |
| leolite (2023.11.22) | 57mb       |
| massive (17.0.0)     | 32mb       |
| massive (groups)     | 44mb       |
