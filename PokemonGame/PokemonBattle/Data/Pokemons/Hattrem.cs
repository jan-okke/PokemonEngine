using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hattrem : Pokemon
	{
		public override string Name => "Hattrem";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Healer(), new Abilities.Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicbounce() };
		public override Stats BaseStats => new Stats(57, 40, 65, 86, 73, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Brutalswing() },
			[1] = new List<Move>() { new Moves.Brutalswing(), new Moves.Confusion(), new Moves.Playnice(), new Moves.Lifedew(), new Moves.Disarmingvoice() },
			[15] = new List<Move>() { new Moves.Aromatherapy() },
			[20] = new List<Move>() { new Moves.Psybeam() },
			[25] = new List<Move>() { new Moves.Healpulse() },
			[30] = new List<Move>() { new Moves.Dazzlinggleam() },
			[37] = new List<Move>() { new Moves.Calmmind() },
			[44] = new List<Move>() { new Moves.Psychic() },
			[51] = new List<Move>() { new Moves.Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thunderwave() };
		public override int Weight => 48;
		public override int ExpYield => 130;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}