According to RejeshVS (2023), in C#, pointer types are special variables that store the memory address of another variable, typically a value type or unmanaged type
(such as primitives, enums, other pointers, or structs made only of unmanaged types) They are used when you need to manipulate memory directly,
for example, performing pointer arithmetic, working with stack-allocated memory (via stackalloc), or pinning objects to prevent the garbage (RejeshVS, 2023)
collector from relocating them Because pointer operations bypass much of C#’s safety features (like garbage collection tracking and type safety),
any code involving pointers must be marked as unsafe. This ensures that pointer usage is explicit and that the programmer is consciously opting into a less safe and more powerful aspect of the language (RejeshVS, 2023).

Reference List:
RejeshVS, 2023. Pointers In C#. [online] Available at: <https://www.c-sharpcorner.com/article/pointers-in-C-Sharp/> [Accessed 08 August 2025].
