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
    And the characters move count is updated with <moveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY | moveCount |
        | 5 | 5 | NORTH | 4 | 5 | 1 |
        | 6 | 5 | SOUTH | 7 | 5 | 2 |
        | 7 | 5 | WEST | 7 | 4 | 3 |
        | 7 | 4 | EAST | 7 | 5 | 4 |
        | 0 | 9 | NORTH | 0 | 9 | 5 |
        | 0 | 0 | WEST | 0 | 0 | 6 |
        | 9 | 0 | SOUTH | 9 | 0 | 7 |
        | 9 | 9 | EAST | 9 | 9 | 8 |
