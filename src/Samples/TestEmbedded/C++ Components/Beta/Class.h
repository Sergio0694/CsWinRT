#pragma once
#include "Class.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::Beta::implementation
{
    struct Class : ClassT<Class>
    {
        Class() = default;

    };
}
namespace winrt::Beta::factory_implementation
{
    struct Class : ClassT<Class, implementation::Class>
    {
    };
}
