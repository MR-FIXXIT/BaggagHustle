# Baggage Hustle

## — A Baggage Screening Simulator —
## TEAM - MANDEM
1. Nandakrishna Giri  
2. Naveen PJ 
3. Mohammed Rizwan
4. Suraj Sunil 
## Link to Build File
[Build File](https://drive.google.com/drive/folders/17CPuz5Uz3OlIx8Y6NFSQqy0-M0PbKZmJ?usp=sharing)

## Abstract
Baggage Hustle is an interactive game that simulates real-life baggage screening mechanisms used at airports, railway stations, and other security checkpoints. Players must identify and filter out luggage containing prohibited items by analyzing realistic X-ray images.

## Introduction
This game educates players on how X-ray scanning systems work, challenging them to efficiently distinguish between safe and flagged baggage.  
- Players **lose a life** if they incorrectly remove a safe bag or fail to identify a bag containing prohibited items.  
- The **game difficulty increases** progressively, testing observation skills and decision-making under pressure.  

## Gameplay Mechanics
- **Scan** luggage using an X-ray interface.
- **Identify** prohibited items hidden in baggage.
- **Approve or reject** bags based on their contents.
- **Survive** as long as possible while keeping error rates low.

## Implementation Details
To create authentic visuals:  
- **Real X-ray images** of baggage were collected.  
- These images were processed into **cutouts of flagged and unflagged items** for clear differentiation.  
- The system **dynamically combines elements** to generate varied, realistic baggage scans, enhancing gameplay.  

## Controls
| Action            | Key/Button      |
|------------------|------------------|
| Interact         | E                |
| Movements        | WASD             |
| Pause            | Escape (Esc)     |

## How to Run the Game
1. **Clone the repository:**  
   ```bash
   git clone https://github.com/yourusername/baggage-hustle.git
   cd baggage-hustle
   ```
2. Open the project in **Unity (mention version, e.g., 2022.3.5f1)**.  
3. Press **Play** in Unity Editor or build the game for your desired platform.


## Technologies Used
- **Unity Engine** (Version: mention specific version)  
- **C# for scripting**  
- **X-ray image processing** for realistic visuals  
- **Randomized baggage generation** for dynamic gameplay

## Contributions

- **Mohammed Rizwan**: Developed the core game mechanisms and programming, ensuring smooth gameplay and logic implementation.
- **Naveen PJ**: Primarily responsible for 3D modeling, creating realistic baggage and item models used throughout the game, and also contributed to the game mechanics.
- **Nandakrishna Giri** : Handled all the X-ray images and their related algorithms, including processing and integration, as well as contributing some 3D models.
- **Suraj Sunil**: Managed all audio work, including sound effects and background music, to enhance the gaming experience.


