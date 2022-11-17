Feature: Move in a Direction
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position.

@acceptance
Scenario Outline: Move in a direction
    Aligned to spec by example table for move sysop

    Given the character starts at the Position with XCoordinates <startingPositionX> 
    And starts at YCoordinates <startingPositionY>
    And the player choses to move in <direction>
    When the character moves
    Then the character is now at Position with XCoordinates <endingPositionX>
    And YCoordinates <endingPositionY>
    Examples:

        | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY |
        | 5 | 5 | NORTH | 4 | 5 |
        | 6 | 5 | SOUTH | 7 | 5 | 
        | 7 | 5 | WEST | 7 | 4 |
        | 7 | 4 | EAST | 7 | 5 |
        | 0 | 9 | NORTH | 0 | 9 |
        | 0 | 0 | WEST | 0 | 0 |
        | 9 | 0 | SOUTH | 9 | 0 |
        | 9 | 9 | EAST | 9 | 9 |
