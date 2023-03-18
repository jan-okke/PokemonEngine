using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ninetales : Pokemon
	{
		public override string Name => "Ninetales";
		public override List<Ability> AvailableAbilities => new() {new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Drought() };
		public override Stats BaseStats => new Stats(73, 76, 75, 81, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nastyplot(), new Incinerate(), new Spite(), new Incinerate(), new Confuseray(), new Willowisp(), new Extrasensory(), new Flamethrower(), new Imprison(), new Firespin(), new Safeguard(), new Inferno(), new Grudge(), new Fireblast(), new Ember(), new Tailwhip(), new Disable(), new Quickattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Foulplay(), new Gigaimpact(), new Heatwave(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irontail(), new Mysticalfire(), new Nastyplot(), new Overheat(), new Payback(), new Powerswap(), new Protect(), new Psychup(), new Psyshock(), new Rest(), new Roar(), new Round(), new Safeguard(), new Scorchingsands(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Tailslap(), new Weatherball(), new Willowisp(), new Zenheadbutt() };
		public override int Weight => 199;
		public override int ExpYield => 177;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 1
		};
	}
}