# perf-string-native-char-array-iteration
A benchmark that compare the iterating performance using for, foreach, copy and reference over a string and native char array

	Operations timed using the system's high-resolution performance counter.
	Timer frequency in ticks per second = 3215351
	Timer is accurate within 311 nanoseconds

	String size: 104857600 Bytes
	Result Scale: Milliseconds

---------------------------
	Run over string using for: 66
	Run over string using foreach: 75
	Run over char array using for: 74
	Run over char array using foreach: 91
	Run over char array using pointer and copy: 79
	Run over char array using pointer and referece: 33

---------------------------
	Run over string using for: 68
	Run over string using foreach: 66
	Run over char array using for: 65
	Run over char array using foreach: 63
	Run over char array using pointer and copy: 66
	Run over char array using pointer and referece: 30

---------------------------
	Run over string using for: 68
	Run over string using foreach: 64
	Run over char array using for: 67
	Run over char array using foreach: 65
	Run over char array using pointer and copy: 68
	Run over char array using pointer and referece: 31

---------------------------
	Run over string using for: 67
	Run over string using foreach: 62
	Run over char array using for: 63
	Run over char array using foreach: 63
	Run over char array using pointer and copy: 66
	Run over char array using pointer and referece: 30

---------------------------
	Run over string using for: 67
	Run over string using foreach: 63
	Run over char array using for: 63
	Run over char array using foreach: 63
	Run over char array using pointer and copy: 65
	Run over char array using pointer and referece: 31
