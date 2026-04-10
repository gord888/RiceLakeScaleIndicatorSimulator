# Rice Lake CSL680 Scale Indicator Simulator

A Windows Forms application that simulates the serial output of a **Rice Lake CSL680** scale indicator. It continuously streams weight data over a COM port using the **Rice Lake Weighing Systems Stream Data Format** (Section 11.3.1), making it useful for developing and testing software that reads from Rice Lake scale indicators without requiring physical hardware.

## Data Format

Each frame follows the Rice Lake Weighing Systems continuous output format:

```
<STX><POL><wwwwwww><UNIT><G/N><S><CR><LF>
```

| Field | Size | Description |
|-------|------|-------------|
| STX   | 1    | ASCII 0x02 (Start of Text) |
| POL   | 1    | Polarity — space (positive) or `-` (negative) |
| wwwwwww | 7  | Weight — right-justified, leading zeros as spaces, two decimal places |
| UNIT  | 1    | `L` = pounds, `K` = kilograms |
| G/N   | 1    | `G` = Gross, `N` = Net |
| S     | 1    | Status — space (Valid), `I` (Invalid), `M` (Motion), `O` (Over/Under Range) |
| TERM  | 2    | `CR` + `LF` |

**Example frame** (125.00 lb, gross, valid):

```
\x02 125.00LG \r\n
```

## Features

- **Configurable serial port settings** — COM port, baud rate, data bits, stop bits, and parity
- **Adjustable weight** — positive and negative values with two decimal places (±999,999.00)
- **Unit selection** — pounds (lb) or kilograms (kg)
- **Error status simulation** — Valid, Invalid, Motion, or Over/Under Range
- **Live output log** — displays each transmitted frame with human-readable escape sequences
- **1-second transmit interval**

## Requirements

- Windows
- .NET 10
- A virtual or physical COM port (e.g. [com0com](https://com0com.sourceforge.net/) for virtual null-modem pairs)

## Getting Started

1. Clone the repository:
   ```
   git clone https://github.com/gord888/RiceLakeScaleIndicatorSimulator.git
   ```
2. Open `Simulator.csproj` in Visual Studio 2026 (or later) and build, or use the CLI:
   ```
   dotnet build
   dotnet run
   ```
3. Select a COM port, configure serial settings, set the desired weight and status, then click **Start**.

## Usage

1. **Serial Port Settings** — choose the COM port and configure baud rate (default 9600), data bits (default 8), stop bits (default One), and parity (default None).
2. **Scale Output** — enter the weight value and select the unit (lb or kg).
3. **Error Status** — select the status flag to include in each frame: Valid, Invalid, Motion, or Over/Under Range.
4. Click **Start** to begin transmitting. The output log shows each frame as it is sent. Click **Stop** to end the simulation.

## License

This project is provided as-is for development and testing purposes.
