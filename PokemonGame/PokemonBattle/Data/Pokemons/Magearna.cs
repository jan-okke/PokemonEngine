using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magearna : Pokemon
	{
		public override string Name => "Magearna";
		public override List<Ability> AvailableAbilities => new() {new Soulheart() };
		public override Stats BaseStats => new Stats(80, 95, 115, 130, 115, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gyroball(), new Helpinghand() },
			[6] = new List<Move>() { new Defensecurl() },
			[12] = new List<Move>() { new Rollout() },
			[18] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Gearup() },
			[30] = new List<Move>() { new Psybeam() },
			[36] = new List<Move>() { new Aurorabeam() },
			[42] = new List<Move>() { new Mindreader() },
			[48] = new List<Move>() { new Shiftgear() },
			[54] = new List<Move>() { new Craftyshield() },
			[60] = new List<Move>() { new Ironhead() },
			[66] = new List<Move>() { new Aurasphere() },
			[72] = new List<Move>() { new Flashcannon() },
			[78] = new List<Move>() { new Painsplit() },
			[84] = new List<Move>() { new Zapcannon() },
			[90] = new List<Move>() { new Fleurcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Aurasphere(), new Batonpass(), new Brickbreak(), new Calmmind(), new Dazzlinggleam(), new Drainingkiss(), new Eerieimpulse(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Energyball(), new Falseswipe(), new Flashcannon(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Imprison(), new Irondefense(), new Ironhead(), new Lightscreen(), new Mistyexplosion(), new Powerswap(), new Protect(), new Reflect(), new Rest(), new Round(), new Selfdestruct(), new Shadowball(), new Snore(), new Solarbeam(), new Speedswap(), new Steelbeam(), new Steelroller(), new Storedpower(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Voltswitch(), new Zenheadbutt() };
		public override int Weight => 805;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
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