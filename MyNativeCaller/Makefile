artifacts:
	$(MAKE) -C ../MyNativeLibrary publish

run: artifacts
	dotnet run -- $(PWD)/../MyNativeLibrary/.artifacts/publish/release_osx-arm64/MyNativeLibrary.dylib
