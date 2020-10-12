# QuantumComputing-Seed-Generator
Generates a 128-bit base64String from Simulated Quantum Computer for use in Encryption

Written in Q#, which is the .Net standard programming language for Quantum Computing and ran on the Quantum Computing Simulator that comes with the Microsoft Quantum Development Kit (QDK)

Prerequisites


 <li><code>.NET Core SDK 3.1 or later</code>
  <li><code>VS Code (Windows, Linux and Mac).</code>
  <li><code>Microsoft QDK for VS Code.</code></li>

<head> </head>

In order to generate our 128bit base64 Crypto String, I simulated a Qubit and used it's randomly generated quantum positions when measured in a collapsed state.

A qubit is a unit of quantum information that can be in superposition. When measured, a qubit can only be either 0 or 1. However, before measurement, the state of the qubit represents the probability of reading either a 0 or a 1 with a measurement. This probabilistic state is known as superposition. We can use this probability to generate random numbers.

This is a simple implementation of the Microsofts QDK (Quantum Development Kit) where the measurement of a single simulated Qubit, namely the qauntum states |0> and |1> were taken as represantations of boolean values, those were later made into a 128 character length bitstring and converted into a byte[] array. That byte array represents a randomly generated string or numeric represantation of a Simulated Quantum Computer. 

### Visualizing the code with the Bloch sphere

In the Bloch sphere, the north pole represents the classical value 0 and the south pole represents the classical value 1. Any superposition can be represented by a point on the sphere (represented by an arrow). The closer the end of the arrow to a pole the higher the probability the qubit collapses into the classical value assigned to that pole when measured. For example, the qubit state represented by the red arrow below has a higher probability of giving the value 0 if we measure it.

<img src="https://docs.microsoft.com/en-us/quantum/media/qrng-bloch.png" width="200" height="200" />

We can use this representation to visualize what the code is doing:

-   First we start with a qubit initialized in the state 0 and apply `H` to create a superposition in which the probabilities for 0 and 1 are the same.

<img src="https://docs.microsoft.com/en-us/quantum/media/qrng-h.png"  height="200" />


-   Then we measure the qubit and save the output:

<img src="https://docs.microsoft.com/en-us/quantum/media/qrng-meas.png" height="200" />

Since the outcome of the measurement is completely random, we have obtained a random bit. We can call this operation several times to create integers or bytes. For example, if we call the operation eight times to obtain eight random bits, we can build random bytes and so on.
