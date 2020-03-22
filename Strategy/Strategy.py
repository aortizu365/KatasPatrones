class Fly():
    def move(self, unit):
        return 10 + unit


class Walk():
    def move(self, unit):
        return unit + 1


class Mix():
    def move(self, unit):
        return 10 + unit


class Viking():
    def __init__(self):
        self.position = 0
        self.move_behavior = Walk()

    def move(self):
        self.position = self.move_behavior.move(self.position)