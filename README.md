MonoConditionalReference
========================

Sample project for using a conditional assembly reference with mono and visual studio.  This demonstrates how to make a reference conditional such that it will build on mono or .NET without triggering any compiler warnings.

```xml
<Choose>
  <When Condition=" '$(OS)' == 'Unix' ">
    <ItemGroup>
      <Reference Include="Mono.Posix" />
    </ItemGroup>
  </When>
</Choose>
```

This technique allows sharing of projects between Monodevelop (Xamarin Studio) and Visual Studio, even though some assemblies and their supporting functionality may only be available on one platform or the other.  In this case, it is the Mono.Posix library.  The conditional reference is useful in conjunction with conditional compilation directives surrounding the platform specific code.

	#if(__MonoCS__)

The project itself is just a contrived example in order to provide a concrete example for conditionally including references.