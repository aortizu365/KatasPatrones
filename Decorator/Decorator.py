class Marine:
    def __init__(self, damage, armor):
        self.damage = damage
        self.armor = armor


class Marine_weapon_upgrade:
    def __init__(self, marine):
        self.instance = marine

    @property
    def damage(self):
        return self.instance.damage + 1

    @property
    def armor(self):
        return self.instance.armor


class Marine_armor_upgrade:
    def __init__(self, marine):
        self.instance = marine

    @property
    def damage(self):
        return self.instance.damage

    @property
    def armor(self):
        return self.instance.armor + 1
