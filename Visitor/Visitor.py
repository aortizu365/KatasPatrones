class Marine:
    def __init__(self):
        self.health = 100

    def accept(self, visitor):
        self.health = visitor.visit_light(self.health)


class Marauder:
    def __init__(self):
        self.health = 125

    def accept(self, visitor):
        self.health = visitor.visit_armored(self.health)


class TankBullet:
    def visit_light(self, unit):
        return unit - 21

    def visit_armored(self, unit):
        return unit - 32
