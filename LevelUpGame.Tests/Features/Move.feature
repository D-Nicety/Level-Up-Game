Feature: Move in a Direction
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position.

@acceptance
Scenario Outline: Move in a direction
    Aligned to spec by example table for move sysop

    Given the character starts at the Position with XCoordinates <startingPositionX> 
    And starts at YCoordinates <startingPositionY>
    And starts at MoveCount <startingMoveCount>
    And the player choses to move in <direction>
    When the character moves
    Then the character is now at Position with XCoordinates <endingPositionX>
    And YCoordinates <endingPositionY>
    And MoveCount <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY | startingMoveCount | endingMoveCount |
        | 5 | 5 | NORTH | 4 | 5 | 1 | 2 |
        | 6 | 5 | SOUTH | 7 | 5 | 2 | 3 |
        | 7 | 5 | WEST | 7 | 4 | 12 | 13 |
        | 7 | 4 | EAST | 7 | 5 | 8 | 9 |
        | 0 | 9 | NORTH | 0 | 9 | 5 | 6 |
        | 0 | 0 | WEST | 0 | 0 | 16 | 17 |
        | 9 | 0 | SOUTH | 9 | 0 | 7 | 8 |
        | 9 | 9 | EAST | 9 | 9 | 18 | 19 |
