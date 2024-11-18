https://telegra.ph/Benchi-navskidku-Morpeh-vs-LeoLite-04-17

## Environment

![image](https://github.com/user-attachments/assets/6e9d60d5-819e-4557-8d31-4ddc83fed7fd)

## Build

Standard use cases without case-specific optimizations; IL2CPP Release build.

## Results

| Test                                         | morpeh (2024.1.0)  | leolite (2023.11.22) | massive (17.0.0) |
| -------------------------------------------- | ------------------ | -------------------- | ---------------- |
| Modify 4 components in 500K entities         | 3.7ms              | 3.9ms                | 5.2ms            |
| Remove and add 1 component in 500K entities  | 43.5ms             | 75.5ms               | 8.2ms            |
| Remove and add 3 components in 500K entities | 51.5ms             | 150.9ms              | 16.3ms           |

## Memory consumption with 4 components, 4 filters, and 500K entities

| Project              | ram (mono) |
| -------------------- | ---------- |
| morpeh (2024.1.0)    | 163mb      |
| leolite (2023.11.22) | 57mb       |
| massive (17.0.0)     | 32mb       |
