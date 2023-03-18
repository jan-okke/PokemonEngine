using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Absol : Pokemon
	{
		public override string Name => "Absol";
		public override List<Ability> AvailableAbilities => new() {new Pressure(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(65, 130, 60, 75, 60, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer() },
			[5] = new List<Move>() { new Doubleteam() },
			[10] = new List<Move>() { new Knockoff() },
			[15] = new List<Move>() { new Detect() },
			[20] = new List<Move>() { new Taunt() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Nightslash() },
			[35] = new List<Move>() { new Focusenergy() },
			[40] = new List<Move>() { new Suckerpunch() },
			[45] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Futuresight() },
			[55] = new List<Move>() { new Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Assurance(), new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bounce(), new Brutalswing(), new Calmmind(), new Chargebeam(), new Closecombat(), new Cut(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Flamethrower(), new Flash(), new Focusenergy(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Hail(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Megahorn(), new Payback(), new Playrough(), new Protect(), new Psychocut(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Waterpulse(), new Willowisp(), new Xscissor(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Batonpass(), new Bite(), new Curse(), new Doubleedge(), new Feint(), new Hex(), new Magiccoat(), new Meanlook(), new Megahorn(), new Perishsong(), new Playrough(), new Suckerpunch(), new Zenheadbutt() };
		public override int Weight => 470;
		public override int ExpYield => 163;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}