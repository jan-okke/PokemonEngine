using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spinarak : Pokemon
	{
		public override string Name => "Spinarak";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Insomnia() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
		public override Stats BaseStats => new Stats(40, 60, 40, 40, 40, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Stringshot() },
			[5] = new List<Move>() { new Moves.Absorb() },
			[8] = new List<Move>() { new Moves.Infestation() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[15] = new List<Move>() { new Moves.Nightshade() },
			[19] = new List<Move>() { new Moves.Shadowsneak() },
			[22] = new List<Move>() { new Moves.Furyswipes() },
			[26] = new List<Move>() { new Moves.Suckerpunch() },
			[29] = new List<Move>() { new Moves.Leechlife() },
			[33] = new List<Move>() { new Moves.Agility() },
			[36] = new List<Move>() { new Moves.Pinmissile() },
			[40] = new List<Move>() { new Moves.Psychic() },
			[43] = new List<Move>() { new Moves.Poisonjab() },
			[47] = new List<Move>() { new Moves.Crosspoison() },
			[50] = new List<Move>() { new Moves.Stickyweb() },
			[54] = new List<Move>() { new Moves.Toxicthread() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Leechlife(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Disable(), new Moves.Lunge(), new Moves.Megahorn(), new Moves.Nightslash(), new Moves.Psybeam(), new Moves.Ragepowder(), new Moves.Toxicspikes() };
		public override int Weight => 85;
		public override int ExpYield => 50;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}