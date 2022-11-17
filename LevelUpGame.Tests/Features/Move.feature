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
        | 0 | 0 | NORTH | 0 | 1 |
        | 0 | 0 | SOUTH | 0 | 0 | 