using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Naganadel : Pokemon
	{
		public override string Name => "Naganadel";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(73, 73, 73, 127, 73, 121);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Aircutter() },
			[1] = new List<Move>() { new Aircutter(), new Airslash(), new Dragonpulse(), new Peck(), new Growl(), new Helpinghand(), new Acid() },
			[7] = new List<Move>() { new Furyattack() },
			[14] = new List<Move>() { new Fellstinger() },
			[21] = new List<Move>() { new Charm() },
			[28] = new List<Move>() { new Venoshock() },
			[35] = new List<Move>() { new Venomdrench() },
			[42] = new List<Move>() { new Nastyplot() },
			[49] = new List<Move>() { new Poisonjab() },
			[56] = new List<Move>() { new Gastroacid() },
			[63] = new List<Move>() { new Toxic() },
			[70] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Allyswitch(), new Assurance(), new Breakingswipe(), new Charm(), new Crosspoison(), new Darkpulse(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Fly(), new Gigaimpact(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Leechlife(), new Nastyplot(), new Outrage(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Scaleshot(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Smartstrike(), new Snarl(), new Snore(), new Spikes(), new Substitute(), new Swift(), new Thief(), new Throatchop(), new Thunderbolt(), new Toxicspikes(), new Uproar(), new Uturn(), new Venomdrench(), new Venoshock(), new Xscissor() };
		public override int Weight => 1500;
		public override int ExpYield => 270;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}